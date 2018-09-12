using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           //readfile

            const char DELIM = ',';
            
            //const string FILENAME = "EmployeeData.txt";
            const string FILENAME = @"C:\Users\Anyone\Desktop\WindowsFormsApplication2\WindowsFormsApplication2\bin\Debug\EmployeeData.txt";

            Employee emp = new Employee();

            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;

            label4.Text = "Num Name Salary"+ Environment.NewLine;

            recordIn = reader.ReadLine();

            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);   
                emp.EmpNum = Convert.ToInt32(fields[0]);                  
                emp.Name = fields[1];                                       
                emp.Salary = Convert.ToDouble(fields[2]);
                
                //label4.Text += emp.EmpNum.ToString() + emp.Name + emp.Salary.ToString("C") + Environment.NewLine;
                label4.Text += emp.ToString();

                recordIn = reader.ReadLine();
            }

            reader.Close();
            inFile.Close();
            Console.ReadLine();
    
        }
        
                        
        private void button2_Click(object sender, EventArgs e)
        {               //write function
            
            const string FILENAME = @"C:\Users\Anyone\Desktop\WindowsFormsApplication2\WindowsFormsApplication2\bin\Debug\EmployeeData.txt";

            Employee emp = new Employee();
            
            using (FileStream w = new FileStream(FILENAME, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter wr = new StreamWriter(w))
                {
                    wr.Write(textBox1.Text + Environment.NewLine);

                    wr.Close();
                }
                w.Close();

            }
            
        }

                        //seek function
        private void button3_Click(object sender, EventArgs e)
        {
            const char DELIM = ',';

            //const string FILENAME = @"C:\C#\Chapter.14\Invoices.txt";

            const string FILENAME = "EmployeeData.txt";

            Employee emp = new Employee();
            FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            string recordIn;
            string[] fields;
            double minSalary;

            label6.Text = "";

            minSalary = Convert.ToDouble(textBox2.Text);

            inFile.Seek(0, SeekOrigin.Begin);
            recordIn = reader.ReadLine();

            while (recordIn != null)
            {
                fields = recordIn.Split(DELIM);
                emp.EmpNum = Convert.ToInt32(fields[0]);
                emp.Name = fields[1];
                emp.Salary = Convert.ToDouble(fields[2]);

                if (emp.Salary >= minSalary)
                {
                   label6.Text += emp.EmpNum +" "+ emp.Name + " " + emp.Salary + " " + Environment.NewLine;
                        
                }

                recordIn = reader.ReadLine();
             }

            reader.Close();
            inFile.Close(); 
        }
    }
    class Employee
    {

        public int EmpNum { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee()
        {



        }
        public Employee(int e, string n, double s)
        {
            this.EmpNum = e;
            this.Name = n;
            this.Salary = s;



        }

        public override String ToString()
        {

            return (EmpNum + " " + Name + " " + Salary + Environment.NewLine);

        }
       
    }
}
