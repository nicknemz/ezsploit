﻿using Comet_3.Classes.DLL;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Wpf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using MessageBox = System.Windows.Forms.MessageBox;

namespace ezsploitv
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebClient webClient = new WebClient();

        public DiscordRpcClient client;
        public MainWindow()
        {
            InitializeComponent();
            HomeBorder.Visibility = Visibility.Hidden;
            options.Visibility = Visibility.Hidden;
            notifyBorder.Visibility = Visibility.Hidden;
            notifyBorder2.Visibility = Visibility.Hidden;
            listbox1.Items.Clear();
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");

            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\monaco-editor"))
            {
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
                ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit");
            }
        }

        [DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool Verify([MarshalAs(UnmanagedType.LPStr)] string key);

        [DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string HWID();

        public static string HttpGet(string url)
        {
            using WebClient webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            return webClient.DownloadString(url);
        }

        Storyboard storyboard = new Storyboard();
        TimeSpan halfsecond = TimeSpan.FromMilliseconds(500);
        TimeSpan second = TimeSpan.FromSeconds(1);

        private IEasingFunction Smooth
        {
            get;
            set;
        }
        = new QuadraticEase
        {
            EasingMode = EasingMode.EaseInOut
        };

        public void Fade(DependencyObject Object)
        {
            DoubleAnimation FadeIn = new DoubleAnimation()
            {
                From = 0.0,
                To = 1.0,
                Duration = new Duration(halfsecond),
            };
            Storyboard.SetTarget(FadeIn, Object);
            Storyboard.SetTargetProperty(FadeIn, new PropertyPath("Opacity", 1));
            storyboard.Children.Add(FadeIn);
            storyboard.Begin();
        }

        public void FadeOut(DependencyObject Object)
        {
            DoubleAnimation FadeOut = new DoubleAnimation()
            {
                From = 1.0,
                To = 0.0,
                Duration = new Duration(halfsecond),
            };
            Storyboard.SetTarget(FadeOut, Object);
            Storyboard.SetTargetProperty(FadeOut, new PropertyPath("Opacity", 1));
            storyboard.Children.Add(FadeOut);
            storyboard.Begin();
        }

        public void Resize()
        {
            DoubleAnimation dananimationX = new DoubleAnimation();
            dananimationX.From = MainBorder.Width;
            dananimationX.To = 500;
            dananimationX.Duration = second;
            dananimationX.EasingFunction = Smooth;
            MainBorder.BeginAnimation(WidthProperty, dananimationX);

            DoubleAnimation dananimationY = new DoubleAnimation();
            dananimationY.From = MainBorder.Height;
            dananimationY.To = 370;
            dananimationY.Duration = second;
            dananimationY.EasingFunction = Smooth;
            MainBorder.BeginAnimation(HeightProperty, dananimationY);
        }
        
        public void ObjectShiftPos(DependencyObject Object, Thickness Get, Thickness Set)
        {
            ThicknessAnimation ShiftAnimation = new ThicknessAnimation()
            {
                From = Get,
                To = Set,
                Duration = second,
                EasingFunction = Smooth,
            };
            Storyboard.SetTarget(ShiftAnimation, Object);
            Storyboard.SetTargetProperty(ShiftAnimation, new PropertyPath(MarginProperty));
            storyboard.Children.Add(ShiftAnimation);
            storyboard.Begin();
        }
        private async void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.Fade(this.MainBorder);
            ObjectShiftPos(MainBorder, MainBorder.Margin, new Thickness(0));
            await Task.Delay(2000);
            ObjectShiftPos(MainBorder, MainBorder.Margin, new Thickness(0,0,-300,0));
            this.FadeOut(this.MainBorder);
            HomeBorder.Visibility = Visibility.Visible;
            await Task.Delay(1000);
            MainBorder.Visibility = Visibility.Hidden;
        }

        public void SetText(string text)
        {
            ((WebView2)MonacoEditor).CoreWebView2.ExecuteScriptAsync("SetText(\"" + HttpUtility.JavaScriptStringEncode(text) + "\")");
            
        }

        
        public string GetText()
        {
            
            ((WebView2)MonacoEditor).CoreWebView2.WebMessageReceived += delegate (object __1, CoreWebView2WebMessageReceivedEventArgs argsy)
            {
                zabijsieoki = argsy.TryGetWebMessageAsString();
            };
            return zabijsieoki;
        }
        public string zabijsieoki;
        public void savetext()
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "1")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt", GetText());
            }
        }

        public void readtext()
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "1")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script1text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script2text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script3text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script4text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script5text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script6text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script7text.txt"));
            }
        }

        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Scripts/{listbox1.SelectedItem}"));
                await Task.Delay(100);
                savetext();
            }
            catch (Exception)
            {

            }
            
        }


        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SetText("");
            sendnotify("Textbox cleared!");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            sendnotify("Deleting Script...");
            LogConsole("Deleting Script...");
            File.Delete("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + listbox1.SelectedItem);
            try
            {
                listbox1.Items.Clear();
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            }
            catch (Exception)
            {
                listbox1.Items.Clear();
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
                Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            }
            
        }
       
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            sendnotify("Saving Script...");
            LogConsole("Saving Script...");
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + textBox1.Text + ".txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + textBox1.Text + ".txt", GetText());
            listbox1.Items.Clear();
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listbox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            savetext();
        }

        private void Execute_Click(object sender, RoutedEventArgs e)
        {
            LogConsole("Trying Execute...");
            sendnotify("Trying Execute...");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                new DLLInterfacing().Execute(GetText());
            }
            savetext();
        }

        private async void Close_Click(object sender, RoutedEventArgs e)
        {
            savetext();
            MonacoEditor.Visibility = Visibility.Hidden;
            this.FadeOut(MainGrid);
            await Task.Delay(500);
            Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            window.WindowState = WindowState.Minimized;
        }

        private async void grid1_enter(object sender, RoutedEventArgs e)
        {
            this.FadeOut(options);
            await Task.Delay(500);
            this.Fade(Grid1);
            Grid1.Visibility = Visibility.Visible;
            options.Visibility = Visibility.Hidden;
            
        }

        private async void options_enter(object sender, RoutedEventArgs e)
        {
            savetext();
            this.FadeOut(Grid1);
            await Task.Delay(500);
            this.Fade(options);
            Grid1.Visibility = Visibility.Hidden;
            options.Visibility = Visibility.Visible;
        }

        private void script1_Click(object sender, RoutedEventArgs e)
        {
            savetext();
            
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "1");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script1text.txt"));
        }

        private void script2_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script2text.txt"));
        }

        private void script3_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script3text.txt"));
        }

        private void script4_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script4text.txt"));
        }

        private void script5_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script5text.txt"));
        }

        private void script6_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script6text.txt"));
        }

        private void script7_Click(object sender, RoutedEventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "7");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script7text.txt"));
        }

        private void addtab_Click(object sender, RoutedEventArgs e)
        {
            savetext();


            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "off")
            {
                script2.Visibility = Visibility.Visible;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "on");
                SetText("");
            }
            else
            {
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "off")
                {
                    script3.Visibility = Visibility.Visible;
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "on");
                    SetText("");
                }
                else
                {
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "off")
                    {
                        script4.Visibility = Visibility.Visible;
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "on");
                        SetText("");
                    }
                    else
                    {
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "off")
                        {
                            script5.Visibility = Visibility.Visible;
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "on");
                            SetText("");
                        }
                        else
                        {
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "off")
                            {
                                script6.Visibility = Visibility.Visible;
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "on");
                                SetText("");
                            }
                            else
                            {
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "off")
                                {
                                    script7.Visibility = Visibility.Visible;
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "7");
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "on");
                                    SetText("");
                                }
                                else
                                {
                                    System.Windows.MessageBox.Show("max amount of script tabs is 7");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void remtab_Click(object sender, RoutedEventArgs e)
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "on")
            {
                script7.Visibility = Visibility.Hidden;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "off");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt", "");
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
                {
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
                    readtext();
                }
            }
            else
            {
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "on")
                {
                    script6.Visibility = Visibility.Hidden;
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt", "");
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
                    {
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
                        readtext();
                    }
                }
                else
                {
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "on")
                    {
                        script5.Visibility = Visibility.Hidden;
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt", "");
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
                        {
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
                            readtext();
                        }
                    }
                    else
                    {
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "on")
                        {
                            script4.Visibility = Visibility.Hidden;
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt", "");
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
                            {
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
                                readtext();
                            }
                        }
                        else
                        {
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "on")
                            {
                                script3.Visibility = Visibility.Hidden;
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "off");
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt", "");
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
                                {
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
                                    readtext();
                                }
                            }
                            else
                            {
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "on")
                                {
                                    script2.Visibility = Visibility.Hidden;
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "off");
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt", "");
                                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
                                    {
                                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "1");
                                        readtext();
                                    }
                                }
                                else
                                {
                                    System.Windows.MessageBox.Show("You can't delete script1");
                                }
                            }
                        }
                    }
                }
            }
        }

        public async void sendnotify(string not)
        {
            try
            {
                notifytext.Content = not;
                notifyBorder.Visibility = Visibility.Visible;
                Fade(notifyBorder);
                await Task.Delay(1500);
                FadeOut(notifyBorder);
                await Task.Delay(500);
                notifyBorder.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {

            }
        }

        public async void LogConsole(string sex)
        {
            try
            {
                ((WebView2)MonacoConsole).CoreWebView2.ExecuteScriptAsync("SetText(\"" + HttpUtility.JavaScriptStringEncode(GetConsoleText()) + HttpUtility.JavaScriptStringEncode("\r\n") + HttpUtility.JavaScriptStringEncode(sex) + "\")");
            }
            catch (Exception)
            {
                try
                {
                    ((WebView2)MonacoConsole).CoreWebView2.ExecuteScriptAsync("SetText(\"" + HttpUtility.JavaScriptStringEncode(GetConsoleText()) + HttpUtility.JavaScriptStringEncode("\r\n") + HttpUtility.JavaScriptStringEncode(sex) + "\")");
                }
                catch (Exception)
                {
                    try
                    {
                        ((WebView2)MonacoConsole).CoreWebView2.ExecuteScriptAsync("SetText(\"" + HttpUtility.JavaScriptStringEncode(GetConsoleText()) + HttpUtility.JavaScriptStringEncode("\r\n") + HttpUtility.JavaScriptStringEncode(sex) + "\")");
                    }
                    catch (Exception)
                    {
                        
                    }
                }
            }
        }

        public string zabijsieoki2;
        public string GetConsoleText()
        {

            ((WebView2)MonacoConsole).CoreWebView2.WebMessageReceived += delegate (object __1, CoreWebView2WebMessageReceivedEventArgs argsy)
            {
                zabijsieoki2 = argsy.TryGetWebMessageAsString();
            };
            return zabijsieoki2;
        }

        private async void Grid1_Loaded(object sender1, RoutedEventArgs e1)
        {
            
            await Task.Delay(1800);
            MonacoEditor.Visibility = Visibility.Hidden;
            client = new DiscordRpcClient("1078735530654707772");
            client.Logger = new ConsoleLogger
            {
                Level = LogLevel.Warning
            };
            client.OnReady += async delegate (object sender, ReadyMessage e)
            {

            };
            client.OnPresenceUpdate += delegate (object sender, PresenceMessage e)
            {
            };
            client.Initialize();
            client.SetPresence(new RichPresence
            {
                Details = "Roblox Script Executor",
                State = "join discord plz",
                Timestamps = Timestamps.Now,
                Assets = new Assets
                {
                    LargeImageKey = "https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/ezsploit5.png"
                },
                Buttons = new DiscordRPC.Button[2]
                {
                    new DiscordRPC.Button
                    {
                        Label = "Download",
                        Url = "https://mikusgszyp.github.io/ezsploit/"
                    },
                    new DiscordRPC.Button
                    {
                        Label = "Discord",
                        Url = "https://discord.gg/JJ4Qpe9gSC"
                    }
                }
            });

            script1.Visibility = Visibility.Visible;

            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "on")
            {
                script2.Visibility = Visibility.Visible;
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "on")
                {
                    script3.Visibility = Visibility.Visible;
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "on")
                    {
                        script4.Visibility = Visibility.Visible;
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "on")
                        {
                            script5.Visibility = Visibility.Visible;
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "on")
                            {
                                script6.Visibility = Visibility.Visible;
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "on")
                                {
                                    script7.Visibility = Visibility.Visible;

                                }
                                else
                                {
                                    script7.Visibility = Visibility.Hidden;
                                }
                            }
                            else
                            {
                                script6.Visibility = Visibility.Hidden;
                                script7.Visibility = Visibility.Hidden;
                            }
                        }
                        else
                        {
                            script5.Visibility = Visibility.Hidden;
                            script6.Visibility = Visibility.Hidden;
                            script7.Visibility = Visibility.Hidden;
                        }
                    }
                    else
                    {
                        script4.Visibility = Visibility.Hidden;
                        script5.Visibility = Visibility.Hidden;
                        script6.Visibility = Visibility.Hidden;
                        script7.Visibility = Visibility.Hidden;
                    }
                }
                else
                {
                    script3.Visibility = Visibility.Hidden;
                    script4.Visibility = Visibility.Hidden;
                    script5.Visibility = Visibility.Hidden;
                    script6.Visibility = Visibility.Hidden;
                    script7.Visibility = Visibility.Hidden;
                }
            }
            else
            {
                script2.Visibility = Visibility.Hidden;
                script3.Visibility = Visibility.Hidden;
                script4.Visibility = Visibility.Hidden;
                script5.Visibility = Visibility.Hidden;
                script6.Visibility = Visibility.Hidden;
                script7.Visibility = Visibility.Hidden;
            }

            
            readtext();
            savetext();

            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
            {
                LogConsole("Auto-Inject: enabled");
                ProcessWatcher processWatcher = new ProcessWatcher("Windows10Universal");

                processWatcher.Created += async (sender, proc) =>
                {
                    Process RobloxProcess = proc;
                    
                    await Task.Delay(4000);
                    injectezsploit();
                };
            }
            else
            {
                LogConsole("Auto-Inject: disabled");
            }
            await Task.Delay(50);
            LogConsole("Selected API: " + File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt"));
            await Task.Delay(50);
            LogConsole("Welcome to EzSploit!");
            await Task.Delay(50);
            LogConsole("version - 6.2");
            await Task.Delay(50);
            LogConsole("developed by - mikusdev");
            await Task.Delay(1000);
            MonacoEditor.Visibility = Visibility.Visible;
            MonacoConsole.Visibility = Visibility.Hidden;
            sendnotify("EzSploit Loaded!");
        }

        private async void killboblocx_Click(object sender, RoutedEventArgs e)
        {

            Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
            for (int i = 0; i < processesByName.Length; i++)
            {
                await Task.Delay(50);
                LogConsole("Roblox killed");
                processesByName[i].Kill();
            }
        }

        private void ReDownload_Click(object sender, RoutedEventArgs e)
        {
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
            Thread.Sleep(100);
            Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
            Thread.Sleep(50);
            Close();
        }

        private async void fix_Click(object sender, RoutedEventArgs e)
        {
            var message = "Fix Update will fix missing error files, but it will delete: ScriptTabs, configs. Your saved scripts will be preserved. I reccomend you to hit 'ReDownload' button after this action.";
            var title = "EzSploit notification";
            var result = System.Windows.Forms.MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
                    if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                    {
                        Directory.Delete(@"c:\mikusdevPrograms\ezsploit\updatetemp", true);
                    }
                    await Task.Delay(100);
                    Close();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
            }
        }

        private void oxygen_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "Oxygen");
            LogConsole("Selected API: OxygenU");
        }

        private async void autoinject_Click(object sender, RoutedEventArgs e)
        {
            string path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            if (path == "Turned off")
            {
                autoinjbutton.Content = "Turned on";
                autoinjbutton.Foreground = Brushes.Green;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned on");
                await Task.Delay(100);
                path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            }
            else if (path == "Turned on")
            {
                autoinjbutton.Content = "Turned off";
                autoinjbutton.Foreground = Brushes.Red;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned off");
                await Task.Delay(100);
                path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            }
            var message = "You need to restart ezsploit to turn on/off auto inject. Do you want to restart?";
            var title = "EzSploit notification";
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Close();
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
            }
        }

        private void options_Loaded(object sender, RoutedEventArgs e)
        {
            autoinjbutton.Content = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
            {
                autoinjbutton.Foreground = Brushes.Green;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned off")
            {
                autoinjbutton.Foreground = Brushes.Red;
            }
        }

        private void folder1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            LogConsole("Opening File...");
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    SetText(File.ReadAllText(openFileDialog.FileName));

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Could not read file from disk. Original error: {ex.Message}");//display if got error
                }
            }
            savetext();
        }

        private void Injectbutt(object sender, RoutedEventArgs e)
        {
            injectezsploit();
        }

        public void injectezsploit()
        {
            
            LogConsole("Irying Inject...");
            sendnotify("Trying Inject...");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                RuyiAPI.inject();
            }
        }

        private void MonacoEditor_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            savetext();
        }

        private void Grid1_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {

        }
        public int consoleon = 0;
        private void openconsole_Click(object sender, RoutedEventArgs e)
        {
            if (consoleon == 0)
            {
                MonacoEditor.Visibility = Visibility.Hidden;
                MonacoConsole.Visibility = Visibility.Visible;
                consoleon = 1;
            }
            else
            {
                MonacoEditor.Visibility = Visibility.Visible;
                MonacoConsole.Visibility = Visibility.Hidden;
                consoleon = 0;
            }
            
        }
    }
}
