/*
 * Created by: Allison Cook
 * Created on: 11 May, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - Pass or Fail
 * This program takes input for a text file and checks how many students pass a class
 * depending on the wieghts the teacher uses for tests, quizes, assignements and projects
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassFailAllisonC
{
    public partial class PassFailForm : Form
    {

        //file paths
        string filepath = "DATA10.txt";
        string outputFile = "DATA10_Output.txt";

        //declare variables
        float weightTests, weightAssign, weightProjects, weightQuizzes;
        float markTests, markAssign, markProjects, markQuizzes;
        int numStudents, numPassed = 0, counterA, counterB;
        float average;

        public PassFailForm()
        {
            InitializeComponent();
        }

        private void btnParseFile_Click(object sender, EventArgs e)
        {
            //read each line into an array
            string[] lines = System.IO.File.ReadAllLines(filepath);

            //loop through each line of the array of lines
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputFile))
            {
                //loop through each line of the array
                for (counterA = 0; counterA < lines.Length; counterA++)
                {
                    //set the number of sutdents who passed to 0
                    numPassed = 0;

                    //read the first line of the array for the next set of students
                    string line = lines[counterA];

                    //split each weight
                    string[] weights = line.Split(' ');

                    //get the weights for each thing
                    weightTests = float.Parse(weights[0]);
                    weightAssign = float.Parse(weights[1]);
                    weightProjects = float.Parse(weights[2]);
                    weightQuizzes = float.Parse(weights[3]);

                    //for testing see if the weights are right
                    file.WriteLine("weights " + weightTests + " " + weightAssign + " " + weightProjects + " " + weightQuizzes);

                    //get the number of students
                    numStudents = int.Parse(lines[counterA + 1]);

                    //for testing see if the numstudents is right
                    file.WriteLine("Number of students " + numStudents);

                }

                //loop through each student
                for (counterB = counterA + 2; counterB < counterA + 2 + numStudents; counterB++)
                {
                    //get the marks 
                    string marks = lines[counterB];

                    //split the studentmarks
                    string[] studentMarks = marks.Split(' ');

                    //get the mark for each thing
                    markTests = float.Parse(studentMarks[0]);
                    markAssign = float.Parse(studentMarks[1]);
                    markProjects = float.Parse(studentMarks[2]);
                    markQuizzes = float.Parse(studentMarks[3]);

                    //for testing write the marks
                    file.WriteLine("studentMarks " + markTests + " " + markAssign + " " + markProjects + " " + markQuizzes);

                    //calculate the average for the student
                    average = markTests * weightTests + markAssign * weightAssign + +markProjects * weightProjects + markQuizzes * weightQuizzes;

                    //for testing write the students average
                    file.WriteLine("Average " + average);

                    //if the average is over 50 add to the number of students passed
                    if (average >= 50)
                    {
                        numPassed = numPassed + 1;
                    }
                }

                //for testing write the number of students that passed
                file.WriteLine("Number of Students passed is " + numPassed);

                //Restart the counter to start at the next group of students
                counterA = counterB - 1;
            }
        }
    }
}
