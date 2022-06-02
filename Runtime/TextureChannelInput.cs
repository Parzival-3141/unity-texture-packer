
using System.Collections.Generic;
using UnityEngine;

namespace TexPacker
{
    public struct TextureChannelInput
    {
        public bool enabled;
        public TextureChannel output;
        public bool invert;

        public TextureChannelInput(TextureChannel output)
        {
            this.output  = output;
            this.enabled = false;
            this.invert  = false;
        }
    }
}