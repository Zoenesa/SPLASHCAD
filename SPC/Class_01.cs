using Microsoft.VisualBasic;
using System.Text;

namespace SPC
{
    class Class_01
    {
        // Fields
        private long[] long_0 = new long[64];
        private long[] long_1 = new long[31];
        private long[] long_2 = new long[31];

        // Methods
        public Class_01()
        {
        this.long_1[0] = 1L;
        this.long_1[1] = 3L;
        this.long_1[2] = 7L;
        this.long_1[3] = 15L;
        this.long_1[4] = 31L;
        this.long_1[5] = 63L;
        this.long_1[6] = 127L;
        this.long_1[7] = 255L;
        this.long_1[8] = 511L;
        this.long_1[9] = 1023L;
        this.long_1[10] = 2047L;
        this.long_1[11] = 4095L;
        this.long_1[12] = 8191L;
        this.long_1[13] = 16383L;
        this.long_1[14] = 32767L;
        this.long_1[15] = 65535L;
        this.long_1[16] = 131071L;
        this.long_1[17] = 262143L;
        this.long_1[18] = 524287L;
        this.long_1[19] = 1048575L;
        this.long_1[20] = 2097151L;
        this.long_1[21] = 4194303L;
        this.long_1[22] = 8388607L;
        this.long_1[23] = 16777215L;
        this.long_1[24] = 33554431L;
        this.long_1[25] = 67108863L;
        this.long_1[26] = 134217727L;
        this.long_1[27] = 268435455L;
        this.long_1[28] = 536870911L;
        this.long_1[29] = 1073741823L;
        this.long_1[30] = 2147483647L;
        this.long_2[0] = 1L;
        this.long_2[1] = 2L;
        this.long_2[2] = 4L;
        this.long_2[3] = 8L;
        this.long_2[4] = 16L;
        this.long_2[5] = 32L;
        this.long_2[6] = 64L;
        this.long_2[7] = 128L;
        this.long_2[8] = 256L;
        this.long_2[9] = 512L;
        this.long_2[10] = 1024L;
        this.long_2[11] = 2048L;
        this.long_2[12] = 4096L;
        this.long_2[13] = 8192L;
        this.long_2[14] = 16384L;
        this.long_2[15] = 32768L;
        this.long_2[16] = 65536L;
        this.long_2[17] = 131072L;
        this.long_2[18] = 262144L;
        this.long_2[19] = 524288L;
        this.long_2[20] = 1048576L;
        this.long_2[21] = 2097152L;
        this.long_2[22] = 4194304L;
        this.long_2[23] = 8388608L;
        this.long_2[24] = 16777216L;
        this.long_2[25] = 33554432L;
        this.long_2[26] = 67108864L;
        this.long_2[27] = 134217728L;
        this.long_2[28] = 268435456L;
        this.long_2[29] = 536870912L;
        this.long_2[30] = 1073741824L;
        this.long_0[0] = 1116352408L;
        this.long_0[1] = 1899447441L;
        this.long_0[2] = -1245643825L;
        this.long_0[3] = -373957723L;
        this.long_0[4] = 961987163L;
        this.long_0[5] = 1508970993L;
        this.long_0[6] = -1841331548L;
        this.long_0[7] = -1424204075L;
        this.long_0[8] = -670586216L;
        this.long_0[9] = 310598401L;
        this.long_0[10] = 607225278L;
        this.long_0[11] = 1426881987L;
        this.long_0[12] = 1925078388L;
        this.long_0[13] = -2132889090L;
        this.long_0[14] = -1680079193L;
        this.long_0[15] = -1046744716L;
        this.long_0[16] = -459576895L;
        this.long_0[17] = -272742522L;
        this.long_0[18] = 264347078L;
        this.long_0[19] = 604807628L;
        this.long_0[20] = 770255983L;
        this.long_0[21] = 1249150122L;
        this.long_0[22] = 1555081692L;
        this.long_0[23] = 1996064986L;
        this.long_0[24] = -1740746414L;
        this.long_0[25] = -1473132947L;
        this.long_0[26] = -1341970488L;
        this.long_0[27] = -1084653625L;
        this.long_0[28] = -958395405L;
        this.long_0[29] = -710438585L;
        this.long_0[30] = 113926993L;
        this.long_0[31] = 338241895L;
        this.long_0[32] = 666307205L;
        this.long_0[33] = 773529912L;
        this.long_0[34] = 1294757372L;
        this.long_0[35] = 1396182291L;
        this.long_0[36] = 1695183700L;
        this.long_0[37] = 1986661051L;
        this.long_0[38] = -2117940946L;
        this.long_0[39] = -1838011259L;
        this.long_0[40] = -1564481375L;
        this.long_0[41] = -1474664885L;
        this.long_0[42] = -1035236496L;
        this.long_0[43] = -949202525L;
        this.long_0[44] = -778901479L;
        this.long_0[45] = -694614492L;
        this.long_0[46] = -200395387L;
        this.long_0[47] = 275423344L;
        this.long_0[48] = 430227734L;
        this.long_0[49] = 506948616L;
        this.long_0[50] = 659060556L;
        this.long_0[51] = 883997877L;
        this.long_0[52] = 958139571L;
        this.long_0[53] = 1322822218L;
        this.long_0[54] = 1537002063L;
        this.long_0[55] = 1747873779L;
        this.long_0[56] = 1955562222L;
        this.long_0[57] = 2024104815L;
        this.long_0[58] = -2067236844L;
        this.long_0[59] = -1933114872L;
        this.long_0[60] = -1866530822L;
        this.long_0[61] = -1538233109L;
        this.long_0[62] = -1090935817L;
        this.long_0[63] = -965641998L;
        }

        private long method_0(long long_2, int int_0)
        {
            if (int_0 == 0)
            {
                return long_2;
            }
            if (int_0 == 31)
            {
                if ((long_2 & 1L) > 0L)
                {
                    return -2147483648L;
                }
                return 0L;
            }
            if ((int_0 < 0) | (int_0 > 31))
            {
                Microsoft.VisualBasic.Information.Err().Raise(6, null, null, null, null);
            }
            if ((long_2 & this.long_2[31 - int_0]) > 0L)
            {
                return (((long_2 & this.long_1[31 - (int_0 + 1)]) * this.long_2[int_0]) | -2147483648L);
            }
            return ((long_2 & this.long_1[31 - int_0]) * this.long_2[int_0]);
        }

        private long Method_00(long long_3)
        {
            return ((this.method_5(long_3, 17) ^ this.method_5(long_3, 19)) ^ this.method_6(long_3, 10));
        }

        private long[] Method_01(ref string string_0)
        {
            long num = 0L;
            long num1;
            long num2;
            long num3 = (long)Strings.Len(string_0);
            long num4 = checked((checked((checked(num3 + 8L)) / 64L + 1L)) * 16L);
            long[] numArray = new long[checked(checked((int)(checked(num4 - 1L))) + 1)];
            while (num < num3)
            {
                num1 = num / 4L;
                num2 = checked((checked(3L - num % 4L)) * 8L);
                byte[] bytes = Encoding.ASCII.GetBytes(Strings.Mid(string_0, checked((int)(checked(num + 1L))), 1));
                long num5 = (long)bytes[0];
                numArray[checked((int)num1)] = numArray[checked((int)num1)] | this.method_0(num5, checked((int)num2));
                num = checked(num + 1L);
            }
            num1 = num / 4L;
            num2 = checked((checked(3L - num % 4L)) * 8L);
            numArray[checked((int)num1)] = numArray[checked((int)num1)] | this.method_0(128L, checked((int)num2));
            numArray[checked((int)(checked(num4 - 1L)))] = this.method_0(num3, 3);
            numArray[checked((int)(checked(num4 - 2L)))] = this.method_1(num3, 29);
            return numArray;
        }

        private long method_1(long long_3, int int_0)
        {
            if (int_0 == 0)
            {
                return long_3;
            }
            if (int_0 == 31)
            {
                if ((long_3 & -2147483648L) > 0L)
                {
                    return 1L;
                }
                return 0L;
            }
            if ((int_0 < 0) | (int_0 > 31))
            {
                Information.Err().Raise(6, null, null, null, null);
            }
            long num = (long_3 & 2147483646L) / this.long_2[int_0];
            if ((long_3 & -2147483648L) > 0L)
            {
                num |= 1073741824L / this.long_2[int_0 - 1];
            }
            return num;
        }

    private long method_2(long long_3, int int_0)
        {
            long num = long_3 & -2147483648L;
            long num2 = int_0 & -2147483648;
            long num3 = long_3 & 1073741824L;
            long num4 = int_0 & 1073741824;
            long num5 = (long_3 & 1073741823L) + (int_0 & 1073741823);
            if ((num3 & num4) > 0L)
            {
                return (((num5 ^ -2147483648L) ^ num) ^ num2);
            }
            if ((num3 | num4) > 0L)
            {
                if ((num5 & 1073741824L) > 0L)
                {
                    return (((num5 ^ -1073741824L) ^ num) ^ num2);
                }
                return (((num5 ^ 1073741824L) ^ num) ^ num2);
            }
            return ((num5 ^ num) ^ num2);
        }

    private long method_3(long long_3, long long_4, long long_5)
        {
            return ((long_3 & long_4) ^ (~long_3 & long_5));
        }

    private long method_4(long long_3, long long_4, long long_5)
        {
            return (((long_3 & long_4) ^ (long_3 & long_5)) ^ (long_4 & long_5));
        }  

    private long method_5(long long_3, int int_0)
        {
            return (this.method_1(long_3, int_0 & ((int) this.long_1[4])) | 
                this.method_0(long_3, (int) (32L - (int_0 & this.long_1[4]))));
        }

    private long method_6(long long_3, int int_0)
        {
            return this.method_1(long_3, int_0 & ((int) this.long_1[4]));
        }

    private long method_7(long long_3)
        {
            return ((this.method_5(long_3, 2) ^ this.method_5(long_3, 13)) ^ this.method_5(long_3, 22));
        }
 
    private long method_8(long long_3)
        {
            return ((this.method_5(long_3, 6) ^ this.method_5(long_3, 11)) ^ this.method_5(long_3, 25));
        }

    private long method_9(long long_3)
    {
        return ((this.method_5(long_3, 7) ^ this.method_5(long_3, 18)) ^ this.method_6(long_3, 3));
    }

    public string SHAsha(ref string sMessage)
        {
            long[] numArray = new long[8];
            long[] numArray1 = new long[64];
            numArray[0] = 1779033703L;
            numArray[1] = -1150833019L;
            numArray[2] = 1013904242L;
            numArray[3] = -1521486534L;
            numArray[4] = 1359893119L;
            numArray[5] = -1694144372L;
            numArray[6] = 528734635L;
            numArray[7] = 1541459225L;
            long[] numArray2 = this.Method_01(ref sMessage);
            long num = (long)Information.UBound(numArray2, 1);
            for (long i = 0L; i <= num; i = checked(i + 16L))
            {
                long num1 = numArray[0];
                long num2 = numArray[1];
                long num3 = numArray[2];
                long num4 = numArray[3];
                long num5 = numArray[4];
                long num6 = numArray[5];
                long num7 = numArray[6];
                long num8 = numArray[7];
                long num9 = 0L;
                do
                {
                    if (num9 >= 16L)
                    {
                        numArray1[checked((int)num9)] = this.method_2(this.method_2(this.method_2(this.Method_00(numArray1[checked((int)(checked(num9 - 2L)))]), checked((int)numArray1[checked((int)(checked(num9 - 7L)))])), checked((int)this.method_9(numArray1[checked((int)(checked(num9 - 15L)))]))), checked((int)numArray1[checked((int)(checked(num9 - 16L)))]));
                    }
                    else
                    {
                        numArray1[checked((int)num9)] = numArray2[checked((int)(checked(num9 + i)))];
                    }
                    long num10 = this.method_2(this.method_2(this.method_2(this.method_2(num8, checked((int)this.method_8(num5))), checked((int)this.method_3(num5, num6, num7))), checked((int)this.long_2[checked((int)num9)])), checked((int)numArray1[checked((int)num9)]));
                    long num11 = this.method_2(this.method_7(num1), checked((int)this.method_4(num1, num2, num3)));
                    num8 = num7;
                    num7 = num6;
                    num6 = num5;
                    num5 = this.method_2(num4, checked((int)num10));
                    num4 = num3;
                    num3 = num2;
                    num2 = num1;
                    num1 = this.method_2(num10, checked((int)num11));
                    num9 = checked(num9 + 1L);
                }
                while (num9 <= 63L);
                numArray[0] = this.method_2(num1, checked((int)numArray[0]));
                numArray[1] = this.method_2(num2, checked((int)numArray[1]));
                numArray[2] = this.method_2(num3, checked((int)numArray[2]));
                numArray[3] = this.method_2(num4, checked((int)numArray[3]));
                numArray[4] = this.method_2(num5, checked((int)numArray[4]));
                numArray[5] = this.method_2(num6, checked((int)numArray[5]));
                numArray[6] = this.method_2(num7, checked((int)numArray[6]));
                numArray[7] = this.method_2(num8, checked((int)numArray[7]));
            }
            string[] strArrays = new string[] { Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[0])), 8), Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[1])), 8), Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[2])), 8), Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[3])), 8), Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[4])), 8), Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[5])), 8), Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[6])), 8), Strings.Right(string.Concat("00000000", Conversion.Hex(numArray[7])), 8) };
            string str = Strings.LCase(string.Concat(strArrays));
            sMessage = "";
            return str;
        }
        
    }
}
