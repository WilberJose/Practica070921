using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //definir las columnas del DatagridWiew
            dgdata.Columns.Add("idStudent", "codigo");
            dgdata.Columns.Add("firsName", "Nombre");
            dgdata.Columns.Add("lastName", "Apellido");
            dgdata.Columns.Add("age", "Edad");

            //lenar las filas
            foreach(var student in selectAllData())
            {
                dgdata.Rows.Add(student.idStudent, student.firsName, student.lastName, student.age);
            }
        }
        //metodo para retornar la coleccion de datos 
        private List<Student> selectAllData()
        {
            //crear consulta
            List<Student> result = (
                                    from Student in Student.GetStudents()
                                    select new Student()

                                    {
                                        idStudent = Student = Student.idStudent,
                                        firsName = Student.firsName,
                                        lastName = Student.lastName,
                                        age = Student.age
                                        gender = Student.gender,
                                    }
                                ).Tolist();

            //retorna el resultado de la consulta
            return result;

        }


    }
}
