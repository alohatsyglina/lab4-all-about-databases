using System;
using System.IO;

namespace lab4
{
    /// <summary>
    /// Интерфейс с возможными операциями 
    /// </summary>
    interface DB
    {
        void createDataBase();
        void createTable();
        void dropTable();
        void createView();
        void dropView();
        void createIndex();
        void dropIndex();
        void createSequence();
        void dropSequence();
        void addConstraint();
    }
    /// <summary>
    /// класс для работы с Oracle
    /// </summary>
    class Oracle : DB
    {
        public void createDataBase()
        {
            Console.WriteLine("Oracle: создать базу данных");
        }
        public void createTable()
        {
            Console.WriteLine("Oracle: добавить таблицу");
        }
        public void dropTable()
        {
            Console.WriteLine("Oracle: удалить таблицу");
        }
        public void createView()
        {
            Console.WriteLine("Oracle: создать представление");
        }
        public void dropView()
        {
            Console.WriteLine("Oracle: удалить представление");
        }
        public void createIndex()
        {
            Console.WriteLine("Oracle: создать индекс");
        }
        public void dropIndex()
        {
            Console.WriteLine("Oracle: удалить индекс");
        }
        public void createSequence()
        {
            Console.WriteLine("Oracle: удалить последовательность");
        }
        public void dropSequence()
        {
            Console.WriteLine("Oracle: удалить последовательность");
        }
        public void addConstraint()
        {
            Console.WriteLine("Oracle: добавить ограничение");
        }
    }
    /// <summary>
    /// Класс для работы с MySQL
    /// </summary>
    class MySQL : DB
    {
        public void createDataBase()
        {
            Console.WriteLine("MySQL: создать базу данных");
        }
        public void createTable()
        {
            Console.WriteLine("MySQL: добавить таблицу");
        }
        public void dropTable()
        {
            Console.WriteLine("MySQL: удалить таблицу");
        }
        public void createView()
        {
            Console.WriteLine("MySQL: создать представление");
        }
        public void dropView()
        {
            Console.WriteLine("MySQL: удалить представление");
        }
        public void createIndex()
        {
            Console.WriteLine("MySQL: создать индекс");
        }
        public void dropIndex()
        {
            Console.WriteLine("MySQL: удалить индекс");
        }
        public void createSequence()
        {
            Console.WriteLine("MySQL: удалить последовательность");
        }
        public void dropSequence()
        {
            Console.WriteLine("MySQL: удалить последовательность");
        }
        public void addConstraint()
        {
            Console.WriteLine("MySQL: добавить ограничение");
        }
    }
    /// <summary>
    /// PostgreSQl
    /// </summary>
    class PostgreSQL : DB
    {
        public void createDataBase()
        {
            Console.WriteLine("PostgreSQL: создать базу данных");
        }
        public void createTable()
        {
            Console.WriteLine("PostgreSQL: добавить таблицу");
        }
        public void dropTable()
        {
            Console.WriteLine("PostgreSQL: удалить таблицу");
        }
        public void createView()
        {
            Console.WriteLine("PostgreSQL: создать представление");
        }
        public void dropView()
        {
            Console.WriteLine("PostgreSQL: удалить представление");
        }
        public void createIndex()
        {
            Console.WriteLine("PostgreSQL: создать индекс");
        }
        public void dropIndex()
        {
            Console.WriteLine("PostgreSQL: удалить индекс");
        }
        public void createSequence()
        {
            Console.WriteLine("PostgreSQL: удалить последовательность");
        }
        public void dropSequence()
        {
            Console.WriteLine("PostgreSQL: удалить последовательность");
        }
        public void addConstraint()
        {
            Console.WriteLine("PostgreSQL: добавить ограничение");
        }
    }
    /// <summary>
    /// Класс Client, зависит от БД
    /// </summary>
    class Client
    {
        DB db;
        public Client(DB database)
        {
            db = database;
        }

        public void chooseAction(int usersAction)
        {
            try
            {
                switch (usersAction)
                {
                    case 1:
                        db.createDataBase();
                        break;
                    case 2:
                        db.createTable();
                        break;
                    case 3:
                        db.dropTable();
                        break;
                    case 4:
                        db.createView();
                        break;
                    case 5:
                        db.dropView();
                        break;
                    case 6:
                        db.createIndex();
                        break;
                    case 7:
                        db.dropIndex();
                        break;
                    case 8:
                        db.createSequence();
                        break;
                    case 9:
                        db.dropSequence();
                        break;
                    case 10:
                        db.addConstraint();
                        break;
                    default:
                        throw new ArgumentException("Операции с таким номер не существует");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return;
            }
        }
    }
    /// <summary>
    /// Тело программы
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {      
            Console.WriteLine("Введите название СУБД, с который вы будете работать: \nДоступные СУБД: Oracle, MySQL, PostgreSQL");

            string name = Console.ReadLine();
            name = name.ToLower();
            DB userDB;
            try
            {
                switch (name)
                {
                    case "oracle":
                        userDB = new Oracle();
                        break;
                    case "mysql":
                        userDB = new MySQL();
                        break;
                    case "postgresql":
                        userDB = new PostgreSQL();
                        break;
                    case "":
                        throw new ArgumentException("Вы ничего не ввели");                        
                    default:
                        throw new ArgumentException("Название СУБД введено неверно");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
                return;
            }
            

                Console.WriteLine("Через запятую введите номера операций, которые вы хотите выполнить:" +
                    "\nСписок доступных операций:\n1 - Создать базу данных,\n2 - Добавить таблицу" +
                    "\n3 - Удалить таблицу\n4 - Добавить представление\n5 - Удалить представление" +
                    "\n6 - Создать индекс\n7 - Удалить индекс\n8 - Создать последовательность" +
                    "\n9 - Удалить последовательность\n10 - Добавить ограничение");

                string acts = Console.ReadLine();
                Console.WriteLine();
                string[] actions = acts.Split(",");
                int actionName;
                Client c = new Client(userDB);
            try
            {

                for (int i = 0; i < actions.Length; i++)
                {
                    actionName = Int32.Parse(actions[i]);
                    throw new ArgumentException("ааааа");
                    c.chooseAction(actionName);
                }
                
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
           
        }
    }
}
