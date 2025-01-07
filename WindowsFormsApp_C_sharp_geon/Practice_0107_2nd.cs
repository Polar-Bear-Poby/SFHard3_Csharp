using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp_C_sharp_geon
{
    public partial class Practice_0107_2nd : Form
    {
        private ProgressBar[] progressBars;
        private Label[] labels;
        private Thread[] threads;
        private Random random = new Random();
        private bool raceInProgress = false;
        private int rankCounter = 1;
        private Stopwatch stopwatch = new Stopwatch();
        private List<string> raceResults = new List<string>();

        public Practice_0107_2nd()
        {
            InitializeComponent();

            // ProgressBar와 Label 배열 초기화
            progressBars = new ProgressBar[] { progressBar1, progressBar2, progressBar3, progressBar4, progressBar5 };
            labels = new Label[] { label1, label2, label3, label4, label5 };
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (raceInProgress)
            {
                MessageBox.Show("Race is already in progress!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            raceInProgress = true;
            rankCounter = 1; // 등수 초기화
            raceResults.Clear(); // 결과 리스트 초기화
            stopwatch.Reset();
            stopwatch.Start(); // 스톱워치 시작

            textBoxResults.Clear(); // 결과창 초기화

            // 각 ProgressBar와 Label 초기화
            for (int i = 0; i < progressBars.Length; i++)
            {
                progressBars[i].Value = 0;
                labels[i].Text = $"Racer {i + 1} ready";
            }

            // 스레드 배열 초기화
            threads = new Thread[progressBars.Length];

            // 각 참가자의 레이스 스레드 생성 및 시작
            for (int i = 0; i < progressBars.Length; i++)
            {
                int playerIndex = i;
                threads[playerIndex] = new Thread(() => RunRace(playerIndex));
                threads[playerIndex].Start();
            }
        }

        private void RunRace(int playerIndex)
        {
            while (progressBars[playerIndex].Value < 100)
            {
                if (!raceInProgress)
                {
                    return; // 레이스가 종료되면 멈춤
                }

                Thread.Sleep(random.Next(10, 50));
                UpdateProgress(playerIndex, 1); // 진행률 1% 증가
            }

            lock (this)
            {
                if (rankCounter <= progressBars.Length)
                {
                    // 완주한 참가자에 등수와 시간 부여
                    double elapsedTime = stopwatch.Elapsed.TotalSeconds; // 경과 시간 계산
                    string result = $"Rank {rankCounter} : racer {playerIndex + 1} , {elapsedTime:F4} seconds";
                    string rankOnly = $"Rank {rankCounter} : racer {playerIndex + 1} ";
                    raceResults.Add(result);
                    AppendToResults(rankOnly);
                    rankCounter++;

                    // 모든 참가자가 완주했는지 확인
                    CheckIfRaceFinished();
                }
            }
        }

        private void UpdateProgress(int playerIndex, int increment)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateProgress(playerIndex, increment)));
            }
            else
            {
                progressBars[playerIndex].Value = Math.Min(progressBars[playerIndex].Value + increment, 100);
                labels[playerIndex].Text = $"Racer {playerIndex + 1}: {progressBars[playerIndex].Value}%";
            }
        }

        private void AppendToResults(string result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => AppendToResults(result)));
            }
            else
            {
                textBoxResults.AppendText(result + Environment.NewLine); // 결과를 텍스트 박스에 추가
            }
        }

        private void CheckIfRaceFinished()
        {
            bool allFinished = true;

            foreach (var progressBar in progressBars)
            {
                if (progressBar.Value < 100)
                {
                    allFinished = false;
                    break;
                }
            }

            if (allFinished)
            {
                raceInProgress = false;
                stopwatch.Stop(); // 스톱워치 멈춤

                // 메시지 박스에 결과 출력
                string resultMessage = "Race completed!\n\n" + string.Join(Environment.NewLine, raceResults);
                MessageBox.Show(resultMessage, "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 화면 초기화
                Invoke(new Action(() => ResetRace()));
            }
        }

        private void ResetRace()
        {
            for (int i = 0; i < progressBars.Length; i++)
            {
                progressBars[i].Value = 0;
                labels[i].Text = $"Racer {i + 1} ready";
            }
        }
        
    }
}
