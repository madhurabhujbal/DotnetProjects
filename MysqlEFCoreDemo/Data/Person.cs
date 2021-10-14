using System;
namespace MysqlEFCoreDemo.Data
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPlayer { get; set; }
    }
}
