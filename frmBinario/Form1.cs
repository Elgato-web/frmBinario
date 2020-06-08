using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text.Length == 0) ;
            {
                MessageBox.Show("Debe ingresar un entero...");
                return; //abandonar la ejecucion
            }
// Actividades:
//1. validar que sea un numero y no letras
//2. validar que el numero ingresado este entre 0 y 255
//3. Diseñar un formulario nuevo o en el mismo, pero ahora 
//debe marcar los chekbox y al hacer clic en un boton
//debe aparecer el equivalente entero
               if (int.TryParse(this.txtNumero.Text)
                int numero =int.Parse( this.txtNumero.Text);
            binario(numero);
        }

        private static void binario(int num)
        {    //declarar un vector de enteros
            int[] vector = new int[8];
            int residuo = 0, i = 0;
            while (num > 0)
            {
                residuo = num % 2;
                vector[i++] = residuo;
                num /= 2;
            }
            i = 0;
            foreach (int k in vector)
            {
                if (i == 0) this.Chekbox1.Cheked= k == 1?true :false;
                if (i == 1) this.Chekbox2.Cheked = k == 1 ? true : false;
                if (i == 2) this.Chekbox3.Cheked = k == 1 ? true : false;
                if (i == 3) this.Chekbox4.Cheked = k == 1 ? true : false;
                if (i == 4) this.Chekbox5.Cheked = k == 1 ? true : false;
                if (i == 5) this.Chekbox6.Cheked = k == 1 ? true : false;
                if (i == 6) this.Chekbox7.Cheked = k == 1 ? true : false;
                if (i == 7) this.Chekbox8.Cheked = k == 1 ? true : false;
                i++;

            }

        }
    }
}

private void btnconvertir_Click(object sender, EventArgs e)
{
    if (this.txtNumero.Text.Length == 0)
    {
        MessageBox.Show("Debe Ingresar un entero...");
        return;//Abandonar ejecución
    }


    if (int.TryParse(txtNumero.Text, out int numero))
    {

        if (numero >= 0 && numero <= 255)
            binario(numero);
        else
            MessageBox.Show("Numero fuera de rango...");
    }
    else
    {
        MessageBox.Show("Debe Ingresar solo valores numericos...");
    }


}

private void groupBox1_Enter(object sender, EventArgs e)
{

}

private void txtnumero_TextChanged(object sender, EventArgs e)
{

}
    }
}