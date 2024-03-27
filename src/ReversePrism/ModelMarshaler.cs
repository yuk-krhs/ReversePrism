using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    public unsafe class ModelMarshaler
    {
        public static byte     GetByte    (IntPtr p)    => *(byte*)p;
        public static sbyte    GetSByte   (IntPtr p)    => *(sbyte*)p;
        public static short    GetInt16   (IntPtr p)    => *(short*)p;
        public static int      GetInt32   (IntPtr p)    => *(int*)p;
        public static long     GetInt64   (IntPtr p)    => *(long*)p;
        public static ushort   GetUInt16  (IntPtr p)    => *(ushort*)p;
        public static uint     GetUInt32  (IntPtr p)    => *(uint*)p;
        public static ulong    GetUInt64  (IntPtr p)    => *(ulong*)p;
        public static float    GetSingle  (IntPtr p)    => *(float*)p;
        public static double   GetDouble  (IntPtr p)    => *(double*)p;
        public static bool     GetBool    (IntPtr p)    => 0 != GetByte(p);
        public static DateTime GetDateTime(IntPtr p)    => DateTime.FromBinary(GetInt64(p+8));
        public static string?  GetString  (IntPtr p)    => GetUnityString(*(IntPtr*)p);

        public static DateTime ToDateTime(Timestamp ts)
        {
            if(null == ts)
                return DateTime.MinValue;

            var dto     = DateTimeOffset.FromUnixTimeSeconds(ts.Seconds);
            var dt      = dto.UtcDateTime.AddSeconds(dto.Nanosecond / 1000);

            return dt;
        }

        public unsafe static List<T>? GetObjectList<T>(IntPtr p, Func<IntPtr, T?> reader)
        {
            var list    = *(IntPtr*)p;

            if(IntPtr.Zero == list)
                return null;

            var array   = *(IntPtr*)(list + 0x10);

            if(array == IntPtr.Zero)
                return null;

            var count   = *(int*)   (list + 0x18);
            var items   = new List<T>();

            for(int i= 0; i < count; ++i)
            {
                var item= *(IntPtr*)(array.ToInt64() + 0x20 + i * 8);
                var obj = reader(item);

                items.Add(obj);
            }

            return items;
        }

        public unsafe static List<string>? GetStringList(IntPtr p)
        {
            var list    = *(IntPtr*)p;

            if(IntPtr.Zero == list)
                return null;

            var array   = *(IntPtr*)(list + 0x10);

            if(array == IntPtr.Zero)
                return null;

            var count   = *(int*)   (list + 0x18);
            var items   = new List<string>();

            for(int i= 0; i < count; ++i)
            {
                var item= *(IntPtr*)(array.ToInt64() + 0x20 + i * 8);
                var str = GetUnityString(item);

                items.Add(str);
            }

            return items;
        }

        public unsafe static List<int>? GetInt32List(IntPtr p)
        {
            var list    = *(IntPtr*)p;

            if(IntPtr.Zero == list)
                return null;

            var array   = *(IntPtr*)(list + 0x10);

            if(array == IntPtr.Zero)
                return null;

            var count   = *(int*)   (list + 0x18);
            var items   = new List<int>();

            for(int i= 0; i < count; ++i)
                items.Add(*(int*)(array.ToInt64() + 0x20 + i * 4));

            return items;
        }

        public unsafe static List<T>? GetEnumList<T>(IntPtr p) where T : Enum
        {
            var list    = *(IntPtr*)p;

            if(IntPtr.Zero == list)
                return null;

            var array   = *(IntPtr*)(list + 0x10);

            if(array == IntPtr.Zero)
                return null;

            var count   = *(int*)   (list + 0x18);
            var items   = new List<T>();

            for(int i= 0; i < count; ++i)
                items.Add((T)Enum.ToObject(typeof(T), *(int*)(array.ToInt64() + 0x20 + i * 4)));

            return items;
        }

        public unsafe static T? GetObject<T>(IntPtr ptr, Func<IntPtr, T?> reader) where T : class
            => reader(*(IntPtr*)ptr);

        public unsafe static string? GetUnityString(IntPtr p)
        {
            if(IntPtr.Zero == p)
                return null;

            var len = *(int*)(p.ToInt64() + 16);
            var s   = Encoding.Unicode.GetString((byte*)(p.ToInt64() + 20), len * 2);

            return s;
        }
    }
}
