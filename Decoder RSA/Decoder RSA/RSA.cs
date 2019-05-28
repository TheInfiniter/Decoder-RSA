using System;
using System.Text;
using System.Numerics;
using System.Windows.Forms;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Decoder_RSA
{
    public partial class RSA : MaterialForm
    {
        int encryption, decryption, module;
        string OpenText;
        byte[] byteArray;
        int[] cipherArray;

        public RSA()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, 
                Primary.Cyan900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            InitializeComponent();
        }

        private bool Ferma(long simple) //тест Ферма на простоту
        {
            if (simple == 2)
                return true; //двойка по умолчанию является простым числом

            Random rand = new Random();
            long test;
            for (int i = 0; i < 150; i++) //проведем тест 150 раз
            {
                
                test = rand.Next((int)simple); //берем случайное число не больше проверяемого

                if (test <= 2)
                    test += 2; //избавляемся от ошибки с двойкой

                if (BigInteger.ModPow(test, simple - 1, simple) != 1) //если число не простое, то сразу же прекращаем проверку
                    return false;
            }
            return true;
        }

        private long SimpleEuclid(long a, long b) //простой алгоритм Евклида (поиск НОД)
        {
            //если b = 0, то параметр а будет НОД, если нет, то рекурсивно вызываем метод, пока не получим НОД
            return ((b > 0) ? SimpleEuclid(b, a % b) : a);
        }

        private int ExtendedEuclid(int a, int b, out int x, out int y) //расширенный алгоритм Евклида для поиска параметра d
        {
            if (a == 0) //если а == 0, то НОД - b, а параметры равны 0 и 1
            {
                x = 0;
                y = 1;
                return b;
            }

            //если же а != 0, то рекурсивно вызываем метод, пока не найдем НОД (параметры забираем по ссылке)
            int x_next, y_next;
            int d_param = ExtendedEuclid(b % a, a, out x_next, out y_next);
            x = y_next - (b / a) * x_next;
            y = x_next;

            return d_param;
        }

        private void Cipher(out int encode_param, out int decrypt_param, out int n_mod) //шифрование данных
        {
            //по условию задачи почти все параметры должны быть уничтожены после успешного шифрования, 
            //поэтому определяем переменные здесь, а не в глобальной области, чтобы после выхода из функции они удалились

            int p_param, q_param, eyler_func, w_param; //параметры p и q, модуль системы n, функция Эйлера
            bool check = false; //результат проверки теста Ферма
            Random rand = new Random();

            do
            {
                p_param = rand.Next(32750); //ищем случайное число в диапазоне от нуля до половины int, чтобы не было переполнения
                check = Ferma(p_param); //и проверяем его на простоту с помощью теста Ферма
            }
            while (check == false);

            check = false;
            do
            {
                q_param = rand.Next(32750); //повторяем то же самое для другого числа, в итоге получим два простых числа
                check = Ferma(q_param);
            }
            while (check == false);

            n_mod = p_param * q_param; //вычисляем модуль системы для дальнейшего использования
            eyler_func = (p_param - 1) * (q_param - 1); //функция Эйлера для подбора параметра шифровки d

            do
            {
                encode_param = rand.Next(8000);
                ExtendedEuclid(encode_param, eyler_func, out w_param, out decrypt_param);
            }
            while (SimpleEuclid(eyler_func, encode_param) != 1 || w_param < 0);
            decrypt_param = w_param;
        }

        private void LoadFromFileFlatButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog read = new OpenFileDialog();
            read.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (read.ShowDialog() == DialogResult.OK)
            {
                SourceText.Text = File.ReadAllText(read.FileName, Encoding.Default);
            }
        }

        private void CipherFlatButton_Click(object sender, EventArgs e)
        {
            CipherText.Text = "";
            OpenText = SourceText.Text;

            //берем строку с нашим текстом, преобразуем ее в кириллицу, и превращаем в набор байт
            byteArray = Encoding.GetEncoding(1251).GetBytes(OpenText);

            cipherArray = new int[byteArray.Length]; //в массиве будем хранить все числа шифротекста

            //вызываем функцию шифрования, из нее получаем необходимые параметры
            Cipher(out encryption, out decryption, out module);

            //кладем ключи в текстовые поля
            OpenedKeyText.Text = Convert.ToString(encryption);
            ClosedKeyText.Text = Convert.ToString(decryption);

            //применяем параметры к тексту, получаем шифр
            for (int i = 0; i < byteArray.Length; i++)
            {
                cipherArray[i] = (int)BigInteger.ModPow(byteArray[i], encryption, module);
                CipherText.Text += cipherArray[i];
                CipherText.Text += " ";
            }
        }

        private void DecipherFlatButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < byteArray.Length; i++)
            {
                byteArray[i] = (byte)BigInteger.ModPow(cipherArray[i], decryption, module);
            }

            OpenText = Encoding.GetEncoding(1251).GetString(byteArray);

            DecipherText.Text = OpenText;
        }
    }
}
