using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 Command_text_wait                        int IL2CPP_TYPE_I4
    // 000 Command_text_no_wait                     int IL2CPP_TYPE_I4
    // 000 Command_wait                             int IL2CPP_TYPE_I4
    // 000 Command_tap_wait                         int IL2CPP_TYPE_I4
    // 000 Command_jump                             int IL2CPP_TYPE_I4
    // 000 Command_cond_flag                        int IL2CPP_TYPE_I4
    // 000 Command_cond_flag_not                    int IL2CPP_TYPE_I4
    // 000 Command_cond_value_eq                    int IL2CPP_TYPE_I4
    // 000 Command_cond_value_neq                   int IL2CPP_TYPE_I4
    // 000 Command_cond_value_ge                    int IL2CPP_TYPE_I4
    // 000 Command_cond_value_le                    int IL2CPP_TYPE_I4
    // 000 Command_flag                             int IL2CPP_TYPE_I4
    // 000 Command_value                            int IL2CPP_TYPE_I4
    // 000 Command_value_add                        int IL2CPP_TYPE_I4
    // 000 Command_terminate                        int IL2CPP_TYPE_I4
    // 000 Command_chara_put                        int IL2CPP_TYPE_I4
    // 000 Command_chara_do                         int IL2CPP_TYPE_I4
    // 000 Command_chara_exp                        int IL2CPP_TYPE_I4
    // 000 Command_chara_move                       int IL2CPP_TYPE_I4
    // 000 Command_chara_delete                     int IL2CPP_TYPE_I4
    // 000 Command_fade                             int IL2CPP_TYPE_I4
    // 000 Command_bg_change                        int IL2CPP_TYPE_I4
    // 000 Command_camera_next                      int IL2CPP_TYPE_I4
    // 000 Command_window_begin                     int IL2CPP_TYPE_I4
    // 000 Command_window_nega                      int IL2CPP_TYPE_I4
    // 000 Command_window_end                       int IL2CPP_TYPE_I4
    // 000 Command_window_offset                    int IL2CPP_TYPE_I4
    // 000 Command_set_active_textwindow            int IL2CPP_TYPE_I4
    // 000 Command_chara_turn                       int IL2CPP_TYPE_I4
    // 000 Command_chara_wait_do                    int IL2CPP_TYPE_I4
    // 000 Command_chara_light                      int IL2CPP_TYPE_I4
    // 000 Command_sound_keyon                      int IL2CPP_TYPE_I4
    // 000 Command_bg_2dset                         int IL2CPP_TYPE_I4
    // 000 Command_call_cutscene                    int IL2CPP_TYPE_I4
    // 000 Command_return_cutscene                  int IL2CPP_TYPE_I4
    // 000 Command_chara_preset                     int IL2CPP_TYPE_I4
    // 000 Command_camera_preset                    int IL2CPP_TYPE_I4
    // 000 Command_text_speaker                     int IL2CPP_TYPE_I4
    // 000 Command_chara_preset_pos                 int IL2CPP_TYPE_I4
    // 000 Command_chara_clear_all                  int IL2CPP_TYPE_I4
    // 000 Command_choices_num                      int IL2CPP_TYPE_I4
    // 000 Command_text_choices                     int IL2CPP_TYPE_I4
    // 000 Command_sound_volume                     int IL2CPP_TYPE_I4
    // 000 Command_chara_eye_auto                   int IL2CPP_TYPE_I4
    // 000 Command_sound_replace                    int IL2CPP_TYPE_I4
    // 000 Command_wind_param                       int IL2CPP_TYPE_I4
    // 000 Command_add_prefab                       int IL2CPP_TYPE_I4
    // 000 Command_play_prefab                      int IL2CPP_TYPE_I4
    // 000 Command_delete_prefab                    int IL2CPP_TYPE_I4
    // 000 Command_env_param                        int IL2CPP_TYPE_I4
    // 000 Command_shake_param                      int IL2CPP_TYPE_I4
    // 000 Command_text_prefab                      int IL2CPP_TYPE_I4
    public partial class ScenarioDef
    {

        public static ScenarioDef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ScenarioDef();


            return value;
        }
    }
}
