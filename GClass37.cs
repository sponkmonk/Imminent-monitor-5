﻿// Decompiled with JetBrains decompiler
// Type: GClass37
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using ImminentMonitor.Cef;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

[StandardModule]
public sealed class GClass37
{
  public static string string_0 = Application.StartupPath + "\\Settings\\User\\DediSettings.xml";

  public static void smethod_0(DediSettings dediSettings_0)
  {
    using (StreamWriter streamWriter = new StreamWriter(GClass37.string_0))
      XmlSerializer.FromTypes(new System.Type[1]
      {
        typeof (DediSettings)
      })[0].Serialize((TextWriter) streamWriter, (object) dediSettings_0);
  }

  public static DediSettings smethod_1()
  {
    DediSettings dediSettings;
    try
    {
      if (File.Exists(GClass37.string_0))
      {
        using (StreamReader streamReader = new StreamReader(GClass37.string_0))
          dediSettings = (DediSettings) XmlSerializer.FromTypes(new System.Type[1]
          {
            typeof (DediSettings)
          })[0].Deserialize((TextReader) streamReader);
      }
      else
        dediSettings = (DediSettings) null;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      dediSettings = (DediSettings) null;
      ProjectData.ClearProjectError();
    }
    return dediSettings;
  }
}
