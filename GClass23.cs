﻿// Decompiled with JetBrains decompiler
// Type: GClass23
// Assembly: ImminentMonitor, Version=5.0.0.89, Culture=neutral, PublicKeyToken=null
// MVID: B073CE4A-B7A6-4CA1-871B-499EF3E27493
// Assembly location: C:\Users\Artem\Documents\Code\Imminent Monitor 5\Imminent Monitor.exe

using System.Threading;

public sealed class GClass23
{
  private static readonly byte[] byte_0 = new byte[128]
  {
    (byte) 1,
    (byte) 1,
    (byte) 2,
    (byte) 2,
    (byte) 3,
    (byte) 3,
    (byte) 3,
    (byte) 3,
    (byte) 4,
    (byte) 4,
    (byte) 4,
    (byte) 4,
    (byte) 4,
    (byte) 4,
    (byte) 4,
    (byte) 4,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 5,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 6,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7,
    (byte) 7
  };
  private static readonly short[] short_0 = new short[256]
  {
    (short) -5504,
    (short) -5248,
    (short) -6016,
    (short) -5760,
    (short) -4480,
    (short) -4224,
    (short) -4992,
    (short) -4736,
    (short) -7552,
    (short) -7296,
    (short) -8064,
    (short) -7808,
    (short) -6528,
    (short) -6272,
    (short) -7040,
    (short) -6784,
    (short) -2752,
    (short) -2624,
    (short) -3008,
    (short) -2880,
    (short) -2240,
    (short) -2112,
    (short) -2496,
    (short) -2368,
    (short) -3776,
    (short) -3648,
    (short) -4032,
    (short) -3904,
    (short) -3264,
    (short) -3136,
    (short) -3520,
    (short) -3392,
    (short) -22016,
    (short) -20992,
    (short) -24064,
    (short) -23040,
    (short) -17920,
    (short) -16896,
    (short) -19968,
    (short) -18944,
    (short) -30208,
    (short) -29184,
    (short) -32256,
    (short) -31232,
    (short) -26112,
    (short) -25088,
    (short) -28160,
    (short) -27136,
    (short) -11008,
    (short) -10496,
    (short) -12032,
    (short) -11520,
    (short) -8960,
    (short) -8448,
    (short) -9984,
    (short) -9472,
    (short) -15104,
    (short) -14592,
    (short) -16128,
    (short) -15616,
    (short) -13056,
    (short) -12544,
    (short) -14080,
    (short) -13568,
    (short) -344,
    (short) -328,
    (short) -376,
    (short) -360,
    (short) -280,
    (short) -264,
    (short) -312,
    (short) -296,
    (short) -472,
    (short) -456,
    (short) -504,
    (short) -488,
    (short) -408,
    (short) -392,
    (short) -440,
    (short) -424,
    (short) -88,
    (short) -72,
    (short) -120,
    (short) -104,
    (short) -24,
    (short) -8,
    (short) -56,
    (short) -40,
    (short) -216,
    (short) -200,
    (short) -248,
    (short) -232,
    (short) -152,
    (short) -136,
    (short) -184,
    (short) -168,
    (short) -1376,
    (short) -1312,
    (short) -1504,
    (short) -1440,
    (short) -1120,
    (short) -1056,
    (short) -1248,
    (short) -1184,
    (short) -1888,
    (short) -1824,
    (short) -2016,
    (short) -1952,
    (short) -1632,
    (short) -1568,
    (short) -1760,
    (short) -1696,
    (short) -688,
    (short) -656,
    (short) -752,
    (short) -720,
    (short) -560,
    (short) -528,
    (short) -624,
    (short) -592,
    (short) -944,
    (short) -912,
    (short) -1008,
    (short) -976,
    (short) -816,
    (short) -784,
    (short) -880,
    (short) -848,
    (short) 5504,
    (short) 5248,
    (short) 6016,
    (short) 5760,
    (short) 4480,
    (short) 4224,
    (short) 4992,
    (short) 4736,
    (short) 7552,
    (short) 7296,
    (short) 8064,
    (short) 7808,
    (short) 6528,
    (short) 6272,
    (short) 7040,
    (short) 6784,
    (short) 2752,
    (short) 2624,
    (short) 3008,
    (short) 2880,
    (short) 2240,
    (short) 2112,
    (short) 2496,
    (short) 2368,
    (short) 3776,
    (short) 3648,
    (short) 4032,
    (short) 3904,
    (short) 3264,
    (short) 3136,
    (short) 3520,
    (short) 3392,
    (short) 22016,
    (short) 20992,
    (short) 24064,
    (short) 23040,
    (short) 17920,
    (short) 16896,
    (short) 19968,
    (short) 18944,
    (short) 30208,
    (short) 29184,
    (short) 32256,
    (short) 31232,
    (short) 26112,
    (short) 25088,
    (short) 28160,
    (short) 27136,
    (short) 11008,
    (short) 10496,
    (short) 12032,
    (short) 11520,
    (short) 8960,
    (short) 8448,
    (short) 9984,
    (short) 9472,
    (short) 15104,
    (short) 14592,
    (short) 16128,
    (short) 15616,
    (short) 13056,
    (short) 12544,
    (short) 14080,
    (short) 13568,
    (short) 344,
    (short) 328,
    (short) 376,
    (short) 360,
    (short) 280,
    (short) 264,
    (short) 312,
    (short) 296,
    (short) 472,
    (short) 456,
    (short) 504,
    (short) 488,
    (short) 408,
    (short) 392,
    (short) 440,
    (short) 424,
    (short) 88,
    (short) 72,
    (short) 120,
    (short) 104,
    (short) 24,
    (short) 8,
    (short) 56,
    (short) 40,
    (short) 216,
    (short) 200,
    (short) 248,
    (short) 232,
    (short) 152,
    (short) 136,
    (short) 184,
    (short) 168,
    (short) 1376,
    (short) 1312,
    (short) 1504,
    (short) 1440,
    (short) 1120,
    (short) 1056,
    (short) 1248,
    (short) 1184,
    (short) 1888,
    (short) 1824,
    (short) 2016,
    (short) 1952,
    (short) 1632,
    (short) 1568,
    (short) 1760,
    (short) 1696,
    (short) 688,
    (short) 656,
    (short) 752,
    (short) 720,
    (short) 560,
    (short) 528,
    (short) 624,
    (short) 592,
    (short) 944,
    (short) 912,
    (short) 1008,
    (short) 976,
    (short) 816,
    (short) 784,
    (short) 880,
    (short) 848
  };

  public static byte[] smethod_0(byte[] byte_1, int int_0, int int_1)
  {
    byte[] numArray = new byte[int_1 / 2 - 1 + 1];
    int num = numArray.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      short short_1 = (short) ((int) (short) ((int) byte_1[int_0 + 1] << 8) | (int) byte_1[int_0]);
      int_0 += 2;
      numArray[index] = GClass23.smethod_2(short_1);
    }
    return numArray;
  }

  public static byte[] smethod_1(byte[] byte_1, int int_0, int int_1)
  {
    int location = -1;
    byte[] numArray = new byte[int_1 * 2 - 1 + 1];
    int num1 = int_0;
    int num2 = byte_1.Length - 1;
    for (int index = num1; index <= num2; ++index)
    {
      short num3 = GClass23.short_0[(int) byte_1[index]];
      numArray[Interlocked.Increment(ref location)] = (byte) ((uint) num3 & (uint) byte.MaxValue);
      numArray[Interlocked.Increment(ref location)] = (byte) ((uint) (short) ((int) num3 >> 8) & (uint) byte.MaxValue);
    }
    return numArray;
  }

  private static byte smethod_2(short short_1)
  {
    int num1 = (int) (short) ((int) ~short_1 >> 8) & 128;
    if (num1 == 0)
      short_1 = -short_1;
    if (short_1 > (short) 32635)
      short_1 = (short) 32635;
    byte num2;
    if (short_1 >= (short) 256)
    {
      int num3 = (int) GClass23.byte_0[(int) (short) ((int) short_1 >> 8) & (int) sbyte.MaxValue];
      int num4 = (int) (short) ((int) short_1 >> (num3 + 3 & 15)) & 15;
      num2 = (byte) (num3 << 4 | num4);
    }
    else
      num2 = (byte) ((int) short_1 >> 4);
    return (byte) ((int) num2 ^ (int) (byte) (num1 ^ 85));
  }
}
