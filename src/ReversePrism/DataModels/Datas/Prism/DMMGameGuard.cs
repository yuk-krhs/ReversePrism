using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 NPGAMEMON_UNDEFINED                      int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_COMM_ERROR                     int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_COMM_CLOSE                     int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_SPEEDHACK                      int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_GAMEHACK_KILLED                int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_GAMEHACK_DETECT                int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_INIT_ERROR                     int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_GAMEHACK_DOUBT                 int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_CHECK_CSAUTH                   int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_CHECK_CSAUTH2                  int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_GAMEHACK_REPORT                int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_CHECK_CSAUTH3                  int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_EXIST                    int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_CREATE                   int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_NPSCAN                   int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_THREAD                   int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_INIT                     int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_GAME_EXIST               int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_AUTH_INI                 int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_AUTH_NPGMUP              int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_AUTH_GAMEMON             int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_AUTH_NEWUP               int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_AUTH_GAMEGUARD           int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_AUTH_DLL                 int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_DECRYPT                  int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_CORRUPT_INI              int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_CORRUPT_INI2             int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_NFOUND_INI               int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_NFOUND_NPGMUP            int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_NFOUND_NEWUP             int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_NFOUND_GG                int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_NFOUND_GM                int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_CRYPTOAPI                int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_COMM                     int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_EXECUTE                  int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_EVENT                    int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_NPGMUP                   int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_MOVE_INI                 int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_MOVE_NEWUP               int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_ILLEGAL_PRG              int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_GAMEMON                  int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_SPEEDCHECK               int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_ERROR_GAMEGUARD                int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_PARAM                       int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_INIT                        int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_DOWNCFG                     int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_ABORT                       int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_AUTH                        int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_AUTH_INI                    int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_DECRYPT                     int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_CONNECT                     int IL2CPP_TYPE_I4
    // 000 NPGMUP_ERROR_INI                         int IL2CPP_TYPE_I4
    // 000 NPGG_ERROR_COLLISION                     int IL2CPP_TYPE_I4
    // 000 NPGAMEMON_SUCCESS                        int IL2CPP_TYPE_I4
    // 000 _bAppExit                                bool IL2CPP_TYPE_BOOLEAN
    // 008 _strMsg                                  string IL2CPP_TYPE_STRING
    // 010 ErrCode                                  0001865F38E0 ModelPrimitiveType int int int Int32
    // 014 IsInit                                   000186595C30 ModelPrimitiveType bool bool bool Bool
    // 015 IsCheck                                  000186595C30 ModelPrimitiveType bool bool bool Bool
    // 018 CheckDisposable                          0001867537E0 ModelClassType IDisposable IDisposable IDisposable Pointer
    public partial class DMMGameGuard : DataModel
    {
        public int                                      ErrCode                                 { get; set; }
        public bool                                     IsInit                                  { get; set; }
        public bool                                     IsCheck                                 { get; set; }
        public IDisposable?                             CheckDisposable                         { get; set; }

        public static DMMGameGuard? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new DMMGameGuard() { Pointer= p0 };

            value.ErrCode                                   = GetInt32(new IntPtr(p + 0x010)); // 0245A3C06740 0x10 ErrCode                     ( 0001865F38E0 ModelPrimitiveType int int int Int32 )
            value.IsInit                                    = GetBool(new IntPtr(p + 0x014)); // 0245A3C06760 0x14 IsInit                      ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.IsCheck                                   = GetBool(new IntPtr(p + 0x015)); // 0245A3C06780 0x15 IsCheck                     ( 000186595C30 ModelPrimitiveType bool bool bool Bool )
            value.CheckDisposable                           = GetObject<IDisposable>(new IntPtr(p + 0x018), ReversePrism.DataModels.IDisposable.FromPointer); // 0245A3C067A0 0x18 CheckDisposable             ( 0001867537E0 ModelClassType IDisposable IDisposable IDisposable Pointer )

            return value;
        }
    }
}
