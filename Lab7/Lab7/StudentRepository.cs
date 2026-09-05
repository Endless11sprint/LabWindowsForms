using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace Lab7
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["student"].ConnectionString;

        public StudentRepository() { }
        public IEnumerable<DepartmentModel> GetDepartments()
        {
            var list = new List<DepartmentModel>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_department, name FROM departments", connection))
                using (var dr = cmd.ExecuteReader())
                    while (dr.Read())
                        list.Add(new DepartmentModel { Id = (int)dr[0], Name = dr[1].ToString() });
            }
            return list;
        }

        public IEnumerable<SpecificationModel> GetSpecifications(int deptId)
        {
            var list = new List<SpecificationModel>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_specification, name FROM specifications WHERE id_department_fk = @id", conn))
                {
                    cmd.Parameters.AddWithValue("id", deptId);
                    using (var dr = cmd.ExecuteReader())
                        while (dr.Read()) list.Add(new SpecificationModel { Id = (int)dr[0], Name = dr[1].ToString() });
                }
            }
            return list;
        }
        public IEnumerable<SpecificationModel> GetSpecificationsByDept(int deptId)
        {
            var list = new List<SpecificationModel>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                using (var cmd = new NpgsqlCommand("SELECT id_specification, name FROM specifications WHERE id_department_fk = @id", connection))
                {
                    cmd.Parameters.AddWithValue("@id", deptId);
                    using (var dr = cmd.ExecuteReader())
                        while (dr.Read())
                            list.Add(new SpecificationModel { Id = (int)dr[0], Name = dr[1].ToString() });
                }
            }
            return list;
        }
        public void Add(StudentModel studentModel)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            int newStudentId;
                            string sqlStudent = @"
                                INSERT INTO students (full_name) 
                                VALUES (@full_name) 
                                RETURNING id_student";

                            using (var command = new NpgsqlCommand(sqlStudent, connection))
                            {
                                command.Parameters.AddWithValue("@full_name", studentModel.FullName);
                                newStudentId = (int)command.ExecuteScalar();
                            }

                            string sqlBook = @"
                                INSERT INTO student_books (
                                    record_book_number, 
                                    id_student_fk, 
                                    id_group_fk, 
                                    id_specification_fk, 
                                    date_of_admission
                                ) VALUES (
                                    @record_book, 
                                    @student_id, 
                                    @group, 
                                    (SELECT id_specification FROM specifications WHERE name = @spec_name LIMIT 1), 
                                    @date
                                )";

                            using (var command = new NpgsqlCommand(sqlBook, connection))
                            {
                                command.Parameters.AddWithValue("@record_book", studentModel.RecordBook);
                                command.Parameters.AddWithValue("@student_id", newStudentId);
                                command.Parameters.AddWithValue("@group", studentModel.Group);
                                command.Parameters.AddWithValue("@spec_name", studentModel.Specification);
                                command.Parameters.AddWithValue("@date", DateTime.Parse(studentModel.Date_of_admission));
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при добавлении студента: " + ex.Message);
                }
            }
        }

        public IEnumerable<StudentModel> GetAll()
        {
            var studentList = new List<StudentModel>();
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string sql = @"
                        SELECT 
                            student_books.id_student_book, 
                            student_books.record_book_number, 
                            students.full_name, 
                            student_books.id_group_fk, 
                            departments.name, 
                            specifications.name, 
                            student_books.date_of_admission 
                        FROM student_books 
                        JOIN students ON student_books.id_student_fk = students.id_student 
                        JOIN specifications ON student_books.id_specification_fk = specifications.id_specification 
                        JOIN departments ON specifications.id_department_fk = departments.id_department";

                    using (var command = new NpgsqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                studentList.Add(new StudentModel
                                {
                                    Id = (int)reader[0],
                                    RecordBook = reader[1].ToString(),
                                    FullName = reader[2].ToString(),
                                    Group = reader[3].ToString(),
                                    Department = (int)reader[4],
                                    Specification = (int) reader[5],
                                    Date_of_admission = ((DateTime)reader[6]).ToString("dd.MM.yyyy")
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при получении списка студентов: " + ex.Message);
                }
            }
            return studentList;
        }
        public StudentModel Get(int id)
        {
            StudentModel student = null;
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string sql = @"
                        SELECT 
                            student_books.id_student_book, 
                            student_books.record_book_number, 
                            students.full_name, 
                            student_books.id_group_fk, 
                            departments.name, 
                            specifications.name, 
                            student_books.date_of_admission 
                        FROM student_books 
                        JOIN students ON student_books.id_student_fk = students.id_student 
                        JOIN specifications ON student_books.id_specification_fk = specifications.id_specification 
                        JOIN departments ON specifications.id_department_fk = departments.id_department
                        WHERE student_books.id_student_book = @id";

                    using (var command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                student = new StudentModel
                                {
                                    Id = (int)reader[0],
                                    RecordBook = reader[1].ToString(),
                                    FullName = reader[2].ToString(),
                                    Group = reader[3].ToString(),
                                    Department = (int)reader[4],
                                    Specification = (int)reader[5],
                                    Date_of_admission = ((DateTime)reader[6]).ToString("dd.MM.yyyy")
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при поиске студента: " + ex.Message);
                }
            }
            return student;
        }

        public void Delete(int studentId)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    string sql = "DELETE FROM students WHERE id_student = @id";
                    using (var command = new NpgsqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", studentId);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при удалении студента: " + ex.Message);
                }
            }
        }

        public void Edit(StudentModel studentModel)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string sqlStudent = @"
                                UPDATE students 
                                SET full_name = @full_name 
                                FROM student_books 
                                WHERE students.id_student = student_books.id_student_fk 
                                AND student_books.id_student_book = @id";

                            using (var command = new NpgsqlCommand(sqlStudent, connection))
                            {
                                command.Parameters.AddWithValue("@full_name", studentModel.FullName);
                                command.Parameters.AddWithValue("@id", studentModel.Id);
                                command.ExecuteNonQuery();
                            }

                            string sqlBook = @"
                                UPDATE student_books 
                                SET 
                                    record_book_number = @record_book, 
                                    id_group_fk = @group, 
                                    id_specification_fk = (SELECT id_specification FROM specifications WHERE name = @spec_name LIMIT 1), 
                                    date_of_admission = @date 
                                WHERE id_student_book = @id";

                            using (var command = new NpgsqlCommand(sqlBook, connection))
                            {
                                command.Parameters.AddWithValue("@record_book", studentModel.RecordBook);
                                command.Parameters.AddWithValue("@group", studentModel.Group);
                                command.Parameters.AddWithValue("@spec_name", studentModel.Specification);
                                command.Parameters.AddWithValue("@date", DateTime.Parse(studentModel.Date_of_admission));
                                command.Parameters.AddWithValue("@id", studentModel.Id);
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                        catch (Exception)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Ошибка при редактировании данных: " + ex.Message);
                }
            }
        }
    }
}