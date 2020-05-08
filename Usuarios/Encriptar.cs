using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Usuarios
{
    public class Encriptar
    {
            private static RijndaelManaged rm = new RijndaelManaged();

            public Encriptar() // creamos el constructor de la clase CEncriptacion
            {
                //esteble el modo para el funcionamiento del algoritmo.
                rm.Mode = CipherMode.CBC;
                // establecer el modo de rrelleno utilizado en el algoritmo
                rm.Padding = PaddingMode.PKCS7;
                //establece el tamaño en bits, para la clave secreta
                rm.KeySize = 0x80;
                // establecer el tamaño del bloque en bits para la operacion criptografica
                rm.BlockSize = 0x80;
            }

            //*METODO PARA ENCRIPTAR*//
            public static string EncryptData(string textdata, string EncryptionKey) // metodo de Encriptacion. 
            {
                byte[] passBytes = Encoding.UTF8.GetBytes(EncryptionKey);
                //establece el vector de inicializacion (IV) para el algoritmo simetrico
                byte[] EncryptionKeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
                int len = passBytes.Length; //para obtner la longitud de los datos almacenados en el array.
                if (len > EncryptionKeyBytes.Length)
                {
                    len = EncryptionKeyBytes.Length;
                }
                Array.Copy(passBytes, EncryptionKeyBytes, len);
                rm.Key = EncryptionKeyBytes;
                rm.IV = EncryptionKeyBytes;
                //crea un objeto AES simetrico con la clave actual y el vector de inicializacion IV.
                ICryptoTransform objtransform = rm.CreateEncryptor();
                byte[] textDataByte = Encoding.UTF8.GetBytes(textdata);
                return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
            }

            //*METODO PARA DESENCRIPTAR*//
            public static string DecryptData(string EncryptedText, string EncryptionKey)
            {
                byte[] encryptedTextByte = Convert.FromBase64String(EncryptedText);
                byte[] passBytes = Encoding.UTF8.GetBytes(EncryptionKey);
                byte[] EncryptionKeyBytes = new byte[0x10];

                int len = passBytes.Length; //para obtner la longitud de los datos almacenados en el array.
                if (len > EncryptionKeyBytes.Length)
                {
                    len = EncryptionKeyBytes.Length;
                }

                Array.Copy(passBytes, EncryptionKeyBytes, len);
                rm.Key = EncryptionKeyBytes;
                rm.IV = EncryptionKeyBytes;

                byte[] TextByte = rm.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
                return Encoding.UTF8.GetString(TextByte);
            }
        }
    }

