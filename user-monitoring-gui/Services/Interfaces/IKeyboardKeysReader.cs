namespace user_monitoring_gui.Services.Interfaces
{      /*!
        * @brief Public interfaceinterface for Reading a button press on the keyboard
        */
    public interface IKeyboardKeysReader
    {
        /*!
         * @brief  function that receives a key code when it is pressed
         * @param Doesn't have
         */
        public uint GetKeyCodePressedKey();
    }
}