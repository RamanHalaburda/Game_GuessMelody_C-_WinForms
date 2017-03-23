using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Victorina
    {
        static public List<string> listSongs = new List<string>();
        static public int gameDuration = 60;
        static public int musicDuration = 10;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;
        static public bool limitAnswerTime = true;
        static public int timeForAnswer = 5;

        static string regKeyName = "Software\\MyCompanyName\\GuessMelody"; 

        static public void ReadMusic()
        {
            try
            {
                string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                listSongs.Clear();
                listSongs.AddRange(music_files);
            }
            catch { }
        }

        static public void SaveSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null)
                    return;
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("AllDirectories", allDirectories);
                rk.SetValue("LimitAnswerTime", limitAnswerTime);
                rk.SetValue("TimeForAnswer", timeForAnswer);
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }

        static public void SetSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName);
                if (rk == null)
                    return;
                lastFolder = rk.GetValue("LastFolder").ToString();
                listSongs.AddRange(Directory.GetFiles(Victorina.lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly));
                gameDuration = System.Convert.ToInt32(rk.GetValue("GameDuration"));
                musicDuration = System.Convert.ToInt32(rk.GetValue("MusicDuration"));
                randomStart = System.Convert.ToBoolean(rk.GetValue("RandomStart"));
                allDirectories = System.Convert.ToBoolean(rk.GetValue("AllDirectories"));
                limitAnswerTime = System.Convert.ToBoolean(rk.GetValue("LimitAnswerTime"));
                timeForAnswer = System.Convert.ToInt32(rk.GetValue("TimeForAnswer"));
            }
            finally
            {
                if (rk != null)
                    rk.Close();
            }
        }
    } 
}
