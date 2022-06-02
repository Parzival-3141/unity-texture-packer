using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

namespace TexPacker
{
    public class TextureInput
    {
        public Texture2D texture;

        private Dictionary<TextureChannel, TextureChannelInput> channelInputs = new Dictionary<TextureChannel, TextureChannelInput>
        {
            [TextureChannel.Red]    = new TextureChannelInput(TextureChannel.Red),
            [TextureChannel.Green]  = new TextureChannelInput(TextureChannel.Green),
            [TextureChannel.Blue]   = new TextureChannelInput(TextureChannel.Blue),
            [TextureChannel.Alpha]  = new TextureChannelInput(TextureChannel.Alpha)
        };

        public TextureChannelInput GetChannelInput(TextureChannel channel)
        {
            return channelInputs[channel];
        }

        public void SetChannelInput(TextureChannel channel, TextureChannelInput channelInput)
        {
            channelInputs[channel] = channelInput;
        }
    }
}