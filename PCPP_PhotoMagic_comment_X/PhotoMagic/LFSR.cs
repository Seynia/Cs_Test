using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoMagic
{
    class LFSR
    {
        public LFSR(string seed, int tapIndex)
        {
            int i = 0;
            this.tapIndex = tapIndex;
            len = seed.Length;
            foreach (int bit in seed.Reverse())
                this.seed |= (bit - '0') << i++;
        }

        private int Step()
        {
            MSB = (seed & (1 << len - 1)) >> len - 1;
            tapBit = (seed & (0x01 << tapIndex)) >> tapIndex;
            seed <<= 1;
            LSB = tapBit ^ MSB;
            seed |= LSB;

            return LSB;
        }

        public int generate(int k)
        {
            int kBit = 0;
            for (int i = 0; i < k; i++)
                kBit = (kBit << 0x01) | Step();
            return kBit;
        }

        private int MSB, seed = 0x00, tapBit = 0x01, LSB;
        private readonly int len, tapIndex;
    }
}