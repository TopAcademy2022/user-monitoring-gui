using user_monitoring.Services.Interfaces;

using Hooks;
using System.Drawing;

namespace user_monitoring.Services
{
    public class KeyboardKeysReader : IKeyboardKeysReader
    {
        public uint Key {  get; set; }
        public uint GetKeyCodePressedKey ()
        {
            Hooks.KBDHook.KeyDown += new Hooks.KBDHook.HookKeyPress( KBDHook_KeyDown );
            Hooks.KBDHook.KeyUp += new Hooks.KBDHook.HookKeyPress( KBDHook_KeyUp );
            Hooks.KBDHook.LocalHook = false;
            Hooks.KBDHook.InstallHook();

            return Key;
        }

        void KBDHook_KeyUp ( Hooks.LLKHEventArgs e )
        {
            this.Key = e.LkCode;
        }

        string text = "";

        void KBDHook_KeyDown ( Hooks.LLKHEventArgs e )
        {
            this.Key = e.LkCode;
        }
    }
}