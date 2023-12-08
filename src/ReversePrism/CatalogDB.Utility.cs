using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism
{
    partial class CatalogDB
    {
        public static string Base32Chars    = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

        public static byte[] CalcKey(long size, long label, long encrypt)
            => CalcKey((ulong)size, (ulong)label, (ulong)encrypt);

        public static byte[] CalcKey(ulong size, ulong label, ulong encrypt)
        {
            var buf = new byte[24];
            var idx = 0;

            buf[idx++]  = (byte)(encrypt >> 56);
            buf[idx++]  = (byte)(encrypt >> 48);
            buf[idx++]  = (byte)(encrypt >> 40);
            buf[idx++]  = (byte)(encrypt >> 32);
            buf[idx++]  = (byte)(encrypt >> 24);
            buf[idx++]  = (byte)(encrypt >> 16);
            buf[idx++]  = (byte)(encrypt >>  8);
            buf[idx++]  = (byte)(encrypt >>  0);

            buf[idx++]  = (byte)(label >> 56);
            buf[idx++]  = (byte)(label >> 48);
            buf[idx++]  = (byte)(label >> 40);
            buf[idx++]  = (byte)(label >> 32);
            buf[idx++]  = (byte)(label >> 24);
            buf[idx++]  = (byte)(label >> 16);
            buf[idx++]  = (byte)(label >>  8);
            buf[idx++]  = (byte)(label >>  0);

            buf[idx++]  = (byte)(size >> 56);
            buf[idx++]  = (byte)(size >> 48);
            buf[idx++]  = (byte)(size >> 40);
            buf[idx++]  = (byte)(size >> 32);
            buf[idx++]  = (byte)(size >> 24);
            buf[idx++]  = (byte)(size >> 16);
            buf[idx++]  = (byte)(size >>  8);
            buf[idx++]  = (byte)(size >>  0);

            var hash= System.Security.Cryptography.SHA1.Create().ComputeHash(buf, 0, idx);

            #if DEBUG
            var s1  = string.Join(" ", buf .Select(i => $"{i:X2}"));
            var s2  = string.Join(" ", hash.Select(i => $"{i:X2}"));

            System.Diagnostics.Debug.Print($"Compute AES KEY: SRC  = {s1}");
            System.Diagnostics.Debug.Print($"                 HASH = {s2}");
            #endif

            return hash;
        }

        public static string GetResourceName(long label, long checksum, long size)
            => GetResourceName((ulong)label, (ulong)checksum, (ulong)size);

        public static string GetResourceName(ulong label, ulong checksum, ulong size)
        {
            var buf = new byte[32];
            var idx = 0;

            buf[idx++]  = (byte)(checksum >> 56);
            buf[idx++]  = (byte)(checksum >> 48);
            buf[idx++]  = (byte)(checksum >> 40);
            buf[idx++]  = (byte)(checksum >> 32);
            buf[idx++]  = (byte)(checksum >> 24);
            buf[idx++]  = (byte)(checksum >> 16);
            buf[idx++]  = (byte)(checksum >>  8);
            buf[idx++]  = (byte)(checksum >>  0);

            while(size > 0)
            {
                if(size < 0x80)
                        buf[idx++]  = (byte)size;
                else    buf[idx++]  = (byte)(0x80 | size);

                size >>= 7;
            }

            buf[idx++]  = (byte)(label >> 56);
            buf[idx++]  = (byte)(label >> 48);
            buf[idx++]  = (byte)(label >> 40);
            buf[idx++]  = (byte)(label >> 32);
            buf[idx++]  = (byte)(label >> 24);
            buf[idx++]  = (byte)(label >> 16);
            buf[idx++]  = (byte)(label >>  8);
            buf[idx++]  = (byte)(label >>  0);

            var hash= System.Security.Cryptography.MD5.Create().ComputeHash(buf, 0, idx);
            var str = ToBase32(hash);

            #if DEBUG
            System.Diagnostics.Debug.Print($"Input {string.Join(" ", buf .Select(i => i.ToString("X2")))}");
            System.Diagnostics.Debug.Print($"Hash  {string.Join(" ", hash.Select(i => i.ToString("X2")))}");
            System.Diagnostics.Debug.Print($"Base32 {str}");
            #endif

            return str;
        }

        public static string ToBase32(byte[] data)
        {
            var n   = 8;
            var idx = 0;
            var sb  = new StringBuilder();

            while(idx < data.Length)
            {
                switch(n)
                {
                case 8: sb.Append(Base32Chars[ (data[idx] >> 3)                                                     & 0x1F]);        n= 3; break;
                case 7: sb.Append(Base32Chars[ (data[idx] >> 2)                                                     & 0x1F]);        n= 2; break;
                case 6: sb.Append(Base32Chars[ (data[idx] >> 1)                                                     & 0x1F]);        n= 1; break;
                case 5: sb.Append(Base32Chars[ (data[idx] >> 0)                                                     & 0x1F]); ++idx; n= 8; break;
                case 4: sb.Append(Base32Chars[((data[idx] << 1) | (idx + 1 < data.Length ? (data[idx+1] >> 7) : 0)) & 0x1F]); ++idx; n= 7; break;
                case 3: sb.Append(Base32Chars[((data[idx] << 2) | (idx + 1 < data.Length ? (data[idx+1] >> 6) : 0)) & 0x1F]); ++idx; n= 6; break;
                case 2: sb.Append(Base32Chars[((data[idx] << 3) | (idx + 1 < data.Length ? (data[idx+1] >> 5) : 0)) & 0x1F]); ++idx; n= 5; break;
                case 1: sb.Append(Base32Chars[((data[idx] << 4) | (idx + 1 < data.Length ? (data[idx+1] >> 4) : 0)) & 0x1F]); ++idx; n= 4; break;
                }
            }

            return sb.ToString();
        }

        public static long CalcResourceLabel(string str)
            => CalcCrc64(str, Encoding.ASCII);

        public static long CalcCrc64(string str, Encoding enc)
            => CalcCrc64(enc.GetBytes(str));

        public static long CalcCrc64(byte[] data)
        {
            var crc64   = new System.IO.Hashing.Crc64();

            crc64.Append(data);

            return BitConverter.ToInt64(crc64.GetHashAndReset().Reverse().ToArray(), 0);
        }
    }
}
