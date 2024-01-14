using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Newtonsoft.Json;

namespace Example_Try
{
    public partial class Form1 : Form
    {
        /*BASE*/
        Randomazier randomData = new Randomazier();
        DataClass db = new DataClass();
        string path = "";
        

        /*Special*/
        //Test 1
        private object lockObjectFirstTest = new object();
        private Action<bool> updateDelegateFirstTest;
        private bool StopButtonFirstTest = false;

        //Test 2
        private object lockObjectSecondTest = new object();
        private Action<bool> updateDelegateSecondTest;
        private bool StopButtonSecondTest = false;

        //Test 3
        private object lockObjectThirdTest = new object();
        private Action<bool> updateDelegateThirdTest;
        private bool StopButtonThirdTest = false;


        /*Construct*/
        public Form1()
        {

            InitializeComponent();

            /*1 TEST*/
            updateDelegateFirstTest = updatedStatus =>
                {
                    lock (lockObjectFirstTest)
                    {
                        StopButtonFirstTest = updatedStatus;
                    }
                };

            /*2 TEST*/
            updateDelegateSecondTest = updatedStatus =>
            {
                lock (lockObjectSecondTest)
                {
                    StopButtonSecondTest = updatedStatus;
                }
            };

            /*3 TEST*/
            updateDelegateThirdTest = updatedStatus =>
            {
                lock (lockObjectThirdTest)
                {
                    StopButtonThirdTest = updatedStatus;
                }
            };

            StopTestF.Enabled = false;
            StopTestS.Enabled = false;
            StopTestT.Enabled = false;

            // run async task to check inputField
            Task.Run(() =>
            {
                ThreadCheckInput();
            });


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*thread for check inputField*/

        private async void ThreadCheckInput() 
        {
            while (true)
            {
                await Task.Delay(30);

                if (InputFieldID.Text == "")
                {
                    ChangeStatus("Введите значение",0);
                }
                else 
                {
                    ChangeStatus(InputFieldID.Text, 0);
                }

            }

        }


        /********************************************* Buttons *********************************************/

        private void FirstTestButton_Click(object sender, EventArgs e)
        {
            if (InputFieldID.Text != "")
            {
                
                // create list codes for thread (rewrite to call base or xlsx file)
                List<string> ListCode = db.ListCode;

                // create object 
                ProjectClass project = new ProjectClass(InputFieldID.Text+" Test1", randomData.RandomCode(ListCode));


                buttonStatus(FirstTestButton, false);
                buttonStatus(StopTestF, true);
                //run thread
                Task.Run(() =>
                {
                    TestStart(project, progressBarTestF, FirstTestButton, StopTestF);
                });


            }
            else 
            {
                //call NEED INPUT
                CallEmptyData();
            }
        }

        private void SecondTestButton_Click(object sender, EventArgs e)
        {
            
            if (InputFieldID.Text != "")
            {

                // create list codes for thread (rewrite to call base or xlsx file)
                List<byte> ListByte = db.ListByte;
                List<int> ListIDByte = db.ListIDByte;

                // create object 
                ProjectClass project = new ProjectClass(InputFieldID.Text + " Test2", randomData.RandomIDByte(ListIDByte), randomData.RandomByte(ListByte));

                buttonStatus(SecondTestButton, false);
                buttonStatus(StopTestS, true);
                //run thread
                Task.Run(() =>
                {
                    TestStart(project, progressBarTestS, SecondTestButton, StopTestS);
                }
                );
                

            }
            else
            {
                //call NEED INPUT
                CallEmptyData();
            }
        }

        private void ThirdTestButton_Click(object sender, EventArgs e)
        {
            if (InputFieldID.Text != "")
            {

                // create list codes for thread (rewrite to call base or xlsx file)
                List<double> ListData = db.ListData;
                List<uint> ListSpeed = db.ListSpeed;

                // create object 
                ProjectClass project = new ProjectClass(InputFieldID.Text + " Test3", true, randomData.RandomData(ListData), randomData.RandomSpeed(ListSpeed));


                buttonStatus(ThirdTestButton, false);
                buttonStatus(StopTestT, true);
                //run thread
                Task.Run(() =>
                {
                    TestStart(project, progressBarTestT, ThirdTestButton, StopTestT);
                }
                );


            }
            else
            {
                //call NEED INPUT
                CallEmptyData();
            }
        }

        /// <summary>
        /// Stop Work task for Test1 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopTestF_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeStatusFirst();
                UpdateBarChangeColor(progressBarTestF, Color.Red);
            }
            catch { }
            
        }

        /// <summary>
        /// Stop Work task for Test2 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopTestS_Click(object sender, EventArgs e)
        {

            try
            {
                ChangeStatusSecond();
                UpdateBarChangeColor(progressBarTestS, Color.Red);
            }
            catch { }
        }

        /// <summary>
        /// Stop Work task for Test3 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StopTestT_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeStatusThird();
                UpdateBarChangeColor(progressBarTestT, Color.Red);
            }
            catch { }
        }


        /********************************************* TEST *********************************************/
        private void ChangeStatusFirst()
        {
            lock (lockObjectFirstTest)
            {
                if (StopButtonFirstTest)
                    StopButtonFirstTest = false;
                else
                    StopButtonFirstTest = true;
            }
            updateDelegateFirstTest(StopButtonFirstTest);
        }


        private void ChangeStatusSecond()
        {
            lock (lockObjectSecondTest)
            {
                if (StopButtonSecondTest)
                    StopButtonSecondTest = false;
                else
                    StopButtonSecondTest = true;
            }
            updateDelegateSecondTest(StopButtonSecondTest);
        }


        private void ChangeStatusThird()
        {
            lock (lockObjectThirdTest)
            {
                if (StopButtonThirdTest)
                    StopButtonThirdTest = false;
                else
                    StopButtonThirdTest = true;
            }
            updateDelegateThirdTest(StopButtonThirdTest);
        }


        private async void TestStart(ProjectClass project, ProgressBar bar, Button buttonTest, Button buttonStop)
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();

            bool Error = false;

            int time = randomData.RandomTestTime();

            int Persent = 0;

            bool checkState = checkBox.Checked;

            int SpecialMsgFlag = ((int)project.type);

            bool StopTask = false;

            while (timer.Elapsed.TotalSeconds < time)
            {

                switch (project.type) 
                {
                    case TypeTest.test1:
                        StopTask = StopButtonFirstTest;
                        break;
                    case TypeTest.test2:
                        StopTask = StopButtonSecondTest;
                        break;
                    case TypeTest.test3:
                        StopTask = StopButtonThirdTest;
                        break;

                };

                await Task.Delay(30);
                if (Persent >= 100)
                {
                    Persent = 100;
                }
                else
                {
                    Persent = Convert.ToInt32(timer.Elapsed.TotalSeconds / time * 100);

                }
                ChangeStatus($"Test {SpecialMsgFlag} " + db.ListStatus[1] + $" {Persent}%", SpecialMsgFlag);
                UpdateBar(bar, Persent);
                 
                if (!StopTask)
                {
                    if (checkState)
                    {
                        if (!Error)
                        {

                            //cheker
                            project = ErrorCheck(project);
                            //set error
                            if (project.error)
                                Error = true;
                        }
                    }
                }
                else
                {
                    Persent = 100;
                    string text = "Тест остановлен";
                    ChangeStatus($"Test {SpecialMsgFlag} " + db.ListStatus[2], SpecialMsgFlag);
                    UpdateBar(bar, Persent);
                    CallWarning(text, "Warning Test");
                    break;
                }
                
            }

            if (!StopTask)
            {
                if (Error)
                {
                    CallErrorTest(project, SpecialMsgFlag);
                }
                else
                {
                    ChangeStatus($"Test {SpecialMsgFlag} " + db.ListStatus[3], SpecialMsgFlag);
                    //call save
                    string text = $"Успех {SpecialMsgFlag}-го теста.";
                    CallInfo(text, project);

                }
            }
            //clear
            ChangeStatus("", SpecialMsgFlag);
            buttonStatus(buttonTest, true);
            buttonStatus(buttonStop, false);
            UpdateBar(bar, 0);
            UpdateBarChangeColor(bar, Color.Green);
            updateState(project.type);
        }

        /********************************************* general *********************************************/

        private void updateState(TypeTest typeTest) 
        {
            switch (typeTest)
            {
                case TypeTest.test1:
                    ChangeStatusFirst();
                    break;
                case TypeTest.test2:
                    ChangeStatusSecond();
                    break;
                case TypeTest.test3:
                    ChangeStatusThird();
                    break;

            };

        }


        #region Invoke call in Task async
        private void UpdateBar(ProgressBar bar, int Value)
        {
            Invoke((MethodInvoker)delegate
            {
                bar.Value = Value;
            });
        }

        private void UpdateBarChangeColor(ProgressBar bar, Color color)
        {
            
            Invoke((MethodInvoker)delegate
            {
                bar.ForeColor = color;
            });
            

        }

        private void buttonStatus(Button button, bool status)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = status;
            });
        }
        #endregion


        #region Check Error 
        /// <summary>
        /// Check Error
        /// </summary>
        /// <param name="project"></param>
        /// <returns>Changed project</returns>
        private ProjectClass ErrorCheck(ProjectClass project) 
        {
            ExProject error = CheckerGeneral(project);

            if (error.error == TypeError.none)
                project.error = false;
            else
                project.error = true;

            project.typeerror = error.error;
            project.exProject = error;

            return project;


        }

        /// <summary>
        /// Check project data with random data.
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        private ExProject CheckerGeneral(ProjectClass project)
        {

            switch (project.type) 
            {
                case TypeTest.test1:
                    string rand = randomData.RandomCode(db.ListCode);
                    if (project.Code == rand) 
                        return new ExProject();
                    else
                        return new ExProject(rand,TypeError.code_error);

                case TypeTest.test2:

                    int rand_id = randomData.RandomIDByte(db.ListIDByte);
                    if (project.IDByte == rand_id)
                    {
                        byte rand_byte = randomData.RandomByte(db.ListByte);
                        if (project.Byte == rand_byte)
                            return new ExProject();
                        else
                            return new ExProject( Convert.ToString(rand_byte), TypeError.byte_error);
                    }
                    else
                        return new ExProject(Convert.ToString(rand_id), TypeError.id_error); 

                case TypeTest.test3:

                    bool status_connect = randomData.RandomBool();
                    if (project.ConnectedStatus == status_connect)
                    {
                        uint speed = randomData.RandomSpeed(db.ListSpeed);
                        if (project.Speed >= speed) 
                        {
                            double data = randomData.RandomData(db.ListData);
                            if (project.Data >= data)
                                return new ExProject();
                            else
                                return new ExProject(Convert.ToString(data), TypeError.data_error);

                        }
                        else
                            return new ExProject(Convert.ToString(speed), TypeError.speed_error);
                    }
                    else
                        return new ExProject(Convert.ToString(status_connect), TypeError.connect_error);


            }

            return new ExProject(); ;
        }

        #endregion



        #region Call MSBox
        private void CallInfo(string Text, ProjectClass project)
        {
            MessageBox.Show(Text, "Info Test", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            Save(project);
        }

        private void CallWarning(string Text, string Name) 
        {
            MessageBox.Show(Text, Name, MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
        }

        private void CallError(string Text, ProjectClass project)
        {
            DialogResult res;
            res = MessageBox.Show(Text, "Error Test", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            
            if (res == DialogResult.OK)
            {
                Save(project);
            }

        }
        #endregion


        private void ChangeStatus(string text, int flag)
        {
            switch (flag) 
            {
                case 0:
                    labelStatusInput.Invoke((MethodInvoker)delegate {
                        labelStatusInput.Text = text;
                    });
                    break;
                case 1:
                    labelStatusTestF.Invoke((MethodInvoker)delegate {
                        labelStatusTestF.Text = text;
                    });
                    break;
                case 2:
                    labelStatusTestS.Invoke((MethodInvoker)delegate {
                        labelStatusTestS.Text = text;
                    });
                    break;
                case 3:
                    labelStatusTestT.Invoke((MethodInvoker)delegate {
                        labelStatusTestT.Text = text;
                    });
                    break;
            }
            

        }



        /// <summary>
        /// Set Spesial code for user.
        /// </summary>
        /// <param name="project"></param>
        /// <returns></returns>
        private string SetErrorMessage(ProjectClass project)
        {
            string erorrs_collect = "";

            switch (project.typeerror)
            {
                case TypeError.code_error:
                    erorrs_collect = $"CODE_ERROR";
                    break;
                case TypeError.id_error:
                    erorrs_collect = $"ID_ERROR";
                    break;
                case TypeError.byte_error:
                    erorrs_collect = $"BYTE_ERROR";
                    break;
                case TypeError.connect_error:
                    erorrs_collect = "CONNECT_ERROR";
                    break;
                case TypeError.data_error:
                    erorrs_collect = "DATA_ERROR";
                    break;
                case TypeError.speed_error:
                    erorrs_collect = "SPEED_ERROR";
                    break;
                case TypeError.none:
                    break;
            }

            return erorrs_collect + "->" + project.exProject.data;

        }


        // Empty Data CAll

        private void CallEmptyData()
        {
            string Text = "Введите идентификатор изделия";
            CallWarning(Text, "Отсутствуют данные");
        }

        // error call in thread 

        private void CallErrorTest(ProjectClass project, int index)
        {
            // call ERROR MESSAGE
            string error = SetErrorMessage(project);

            string text = $"Ошибка {index}-го теста {error}. Сохранить результат теста?";
            ChangeStatus($"Test {index} " + db.ListStatus[4] + error, index);
            CallError(text, project);
        }



        private void Save(ProjectClass project)
        {
            string _data = "";
            if (project.type == TypeTest.test1)
            {
                
                _data = $"Результат 1-го тестирования: | {project.Code} | {SetErrorMessage(project)}";
                    
            }

            if (project.type == TypeTest.test2)
            {
                _data = $"Результат 2-го тестирования: | {project.IDByte} | {project.Byte} | {SetErrorMessage(project)}";
                   
            }


            if (project.type == TypeTest.test3)
            {
                _data = $"Результат 3-го тестирования: | {project.ConnectedStatus} | {project.Speed} | {project.Data} | {SetErrorMessage(project)}";
            }
            try
            {
                if (path == "")
                    folderMenuItem();
                string path_to_file = path + $"//{project.name}.txt";

                System.IO.File.WriteAllText(path_to_file, _data);
            }
            catch 
            {
            
            }
        }

        private void folderMenuItem()
        {
            // Show the FolderBrowserDialog.
            Invoke((MethodInvoker)delegate
            {
                var folderBrowserDialog1 = new FolderBrowserDialog();
                DialogResult result;
                result = folderBrowserDialog1.ShowDialog();
                if (result == DialogResult.OK)
                    path = folderBrowserDialog1.SelectedPath;
            });
        }
    }

}
