using Microsoft.EntityFrameworkCore;
using OOO_Bank_NVA.DB;
using OOO_Bank_NVA.Models;
using System;
using System.Windows.Forms;

namespace OOO_Bank_NVA
{
    public partial class Form1 : Form
    {
        BaseWriteRepository<Person> writeRepository;
        DbContextOptions<DB.ApplicationContext> options = DataBaseHelper.Options();
        public Form1()
        {
            InitializeComponent();
            writeRepository = new BaseWriteRepository<Person>();
            var person = new Person()
            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Surname = "Test",
                Phone = "Test"
            };
            writeRepository.Add(person);
            
        }
    }
}
