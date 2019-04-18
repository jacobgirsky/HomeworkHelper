﻿using HomeWorkHelperLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HomeworkHelper
{
    /// <summary>
    /// Interaction logic for student.xaml
    /// </summary>
    /// 

    public partial class homeScreen : Window
    {

        public List<Task_> tasks { get; set; }
        Student stu;
        public homeScreen(Student newStudent)
        {

            InitializeComponent();
            stu = newStudent;
            tasks = new List<Task_>();

            for (int i = 0; i < newStudent.TaskList.Count; i++)
            {
                tasks.Add(newStudent.TaskList[i]);
            }

            DataContext = this;
           
        }
    

        private void AddCourse_Click(object sender, RoutedEventArgs e)
        {
            

            AddCourse addcourse = new AddCourse(stu);

            this.Close();
            addcourse.Show();

        }

        private void View_CourseClick(object sender, RoutedEventArgs e)
        {
            ViewCourses viewCourse = new ViewCourses(stu);
            this.Close();
            viewCourse.Show();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            AddTask add = new AddTask(stu);
            this.Close();
            add.Show();
        }
    }
}
