using Acccount_Manager.Classes;
using Acccount_Manager.Classes.Utility;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.IO;
using Acccount_Manager.Classes.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;

namespace Acccount_Manager.UI
{
    public partial class Injector : Form
    {
        private static readonly string dllPath = Constants.basePath + @"\R3nzSkin.dll";
        private static bool loop = false;

        public Injector()
        {
            InitializeComponent();
            Text = Utils.GenerateString();
        }

        private async void InjectDll(int pid)
        {
            InjectStatus_textBox.BackColor = Color.DarkOrange;
            for (int i = 10; i > 0; i--)
            {
                InjectStatus_textBox.Text = $"Injecting in ({i}s)";
                await Task.Delay(1000);
            }

            InjectStatus_textBox.Text = "Injecting...";

            IntPtr processHandle = Imports.OpenProcess(0x1F0FFF, false, pid);

            if (processHandle == IntPtr.Zero)
                throw new Exception("Could not open process.");

            IntPtr loadLibraryAddr = Imports.GetProcAddress(Imports.GetModuleHandle("kernel32.dll"), "LoadLibraryA");

            if (loadLibraryAddr == IntPtr.Zero)
                throw new Exception("Could not find LoadLibraryA.");

            IntPtr allocMemAddress = Imports.VirtualAllocEx(processHandle, IntPtr.Zero, (uint)((dllPath.Length + 1) * Marshal.SizeOf(typeof(char))), 0x3000, 0x40);

            if (allocMemAddress == IntPtr.Zero)
                throw new Exception("Could not allocate memory in remote process.");

            byte[] bytes = Encoding.Default.GetBytes(dllPath);

            if (!Imports.WriteProcessMemory(processHandle, allocMemAddress, bytes, (uint)bytes.Length, out _))
                throw new Exception("Could not write to process's memory.");

            IntPtr hThread = Imports.CreateRemoteThread(processHandle, IntPtr.Zero, 0, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);

            if (hThread == IntPtr.Zero)
                throw new Exception("Could not create remote thread.");

            InjectStatus_textBox.Text = "Injected";
            InjectStatus_textBox.BackColor = Color.Green;

            Imports.CloseHandle(hThread);
            Imports.CloseHandle(processHandle);
        }

        private async void InjectorBtn_Click(object sender, EventArgs e)
        {
            bool isInjected = false;
            loop = !loop;

            List<Control> controls = new List<Control>()
            {
                InjectorBtn,
                InjectorStatus_textBox,
                LeagueGameStatus_textBox,
                InjectStatus_textBox
            };

            if (!loop) 
            {
                // Set backcolor to red
                foreach (Control c in controls)
                {
                    c.BackColor = Color.Red;
                }

                InjectorBtn.Text = "Start";
                InjectorStatus_textBox.Text = "Stopped";
                LeagueGameStatus_textBox.Text = "Not Found";
                InjectStatus_textBox.Text = "Not Injected";
                loop = false;
                return;
            }

            if (loop)
            {
                InjectorBtn.BackColor = Color.Green;
                InjectorBtn.Text = "Stop";
                while (loop)
                {
                    InjectorStatus_textBox.Text = "Working";
                    InjectorStatus_textBox.BackColor = Color.Green;
                    try
                    {
                        int pid = Utils.GetProcessId("League of Legends");
                        LeagueGameStatus_textBox.Text = "Found";
                        LeagueGameStatus_textBox.BackColor = Color.Green;
                        if (!isInjected)
                        {
                            if (!File.Exists(dllPath))
                            {
                                MessageBox.Show($"DLL not found at:\n{dllPath}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            try
                            {
                                InjectDll(pid);
                                isInjected = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Failed to inject DLL: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch
                    {
                        LeagueGameStatus_textBox.Text = "Not Found";
                        InjectStatus_textBox.Text = "Not Injected";
                        LeagueGameStatus_textBox.BackColor = Color.Red;
                        InjectStatus_textBox.BackColor = Color.Red;
                        isInjected = false;
                    }
                    await Task.Delay(1000);
                }
            }
        }

        private void R3nzSkin_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/R3nzTheCodeGOD/R3nzSkin");
        }
    }
}
