#nullable disable

using System.Diagnostics;
using System.Reflection;

namespace Ex3
{
	public partial class Form1 : Form
	{
		const string FORMAT = "#{0,-10}# #{1,-20}# #{2,-20}#\r\n";
		const string FORMAT_BOTH = "#{0,-15}# #{1,-15}# #{2,-15}#\r\n";
		Process[] processes = Process.GetProcesses();
		Process p = null;
		int id = 0;

		public Form1()
		{
			InitializeComponent();

		}

		public string ChangeLength(string tochange)
		{
			if (tochange.Length > 15)
			{
				return tochange.Substring(0, 12) + "...";
			}

			return tochange;
		}

		public void Separator(TextBox textbox)
		{
			textbox.Text += "===========================================================================\r\n";
		}

		public bool Comprobate(ref Process proc, ref int id)
		{
			if (int.TryParse(txbInfo.Text, out id))
			{
				try
				{
					proc = Process.GetProcessById(id);
				}
				catch (ArgumentException ex)
				{
					txbInfo.Text = "El PID no existe. ";
					txbInfo.Text += ex.ToString();
					return true;
				}
			}
			return false;
		}

		private void btnView_Click(object sender, EventArgs e)
		{
			tbxManager.Text = string.Format(FORMAT, "PID", "Name", "Window title");
			Separator(tbxManager);
			Array.ForEach(processes, proc =>
			{
				tbxManager.Text += string.Format(FORMAT, proc.Id, ChangeLength(proc.ProcessName), ChangeLength(proc.MainWindowTitle));
			});


		}

		private void btnInfo_Click(object sender, EventArgs e)
		{
			bool error = Comprobate(ref p, ref id);

			if (!error)
			{
				try
				{
					ProcessModuleCollection modules = p.Modules;
					ProcessThreadCollection threads = p.Threads;


					tbxManager.Text = string.Format("### PROCESS ID: {0} - NAME: {1} ###\r\n", p.Id, p.ProcessName);
					Separator(tbxManager);
					tbxManager.Text += string.Format(FORMAT_BOTH, "ID", "Thread", "Init");
					Separator(tbxManager);
					for (int i = 0; i < threads.Count; i++)
					{
						tbxManager.Text += string.Format(FORMAT_BOTH, threads[i].Id, ChangeLength(threads[i].ToString()), threads[i].StartTime.ToShortTimeString());

					}

					Separator(tbxManager);
					tbxManager.Text += string.Format(FORMAT_BOTH, "Module", "Name", "File");
					Separator(tbxManager);
					for (int i = 0; i < modules.Count; i++)
					{
						tbxManager.Text += string.Format(FORMAT_BOTH, ChangeLength(modules[i].ToString()), ChangeLength(modules[i].ModuleName), ChangeLength(modules[i].FileName));

					}

				}
				catch (System.ComponentModel.Win32Exception ex)
				{
					Console.WriteLine(ex.HelpLink);
				}
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			bool error = Comprobate(ref p, ref id);

			if (!error)
			{
				p.CloseMainWindow();
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			bool error = Comprobate(ref p, ref id);

			if (!error)
			{
				p.Kill();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string name = txbInfo.Text;
			try
			{
				ProcessStartInfo startInfo = new ProcessStartInfo(name);
				p = Process.Start(startInfo);

			}
			catch (System.ComponentModel.Win32Exception)
			{
				tbxManager.Text = "No application found.";
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Process[] names = Array.FindAll(processes, p => p.ProcessName.StartsWith(txbInfo.Text));

			if (names.Length != 0)
			{
				tbxManager.Text = string.Format(FORMAT, "PID", "Name", "Window title");
				Separator(tbxManager);
				foreach (Process p in names)
				{
					tbxManager.Text += string.Format(FORMAT, p.Id, p.ProcessName, p.MainWindowTitle);
				}
			}
		}
	}
}