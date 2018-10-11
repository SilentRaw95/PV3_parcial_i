using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_5
{
    public partial class Form1 : Form
    {
        //made by miguel
        public Form1()
        {
            InitializeComponent();
        }

        //input functions ley
        private void agunaldo_TextChanged(object sender, System.EventArgs e)
        {
            if(!agunaldo.Text.Equals("") && !salario_mensual.Text.Equals(""))
            {
                Double pago = Double.Parse(salario_mensual.Text);
                Double temp = (Double.Parse(agunaldo.Text) * pago) / 100;
                leyp1.Text = "$ " + temp.ToString();
            }
        }

        private void vacaciones_TextChanged(object sender, System.EventArgs e)
        {
            if (!vacaciones.Text.Equals("") && !salario_mensual.Text.Equals(""))
            {
                Double pago = Double.Parse(salario_mensual.Text);
                Double temp = (Double.Parse(vacaciones.Text) * pago) / 100;
                leyp2.Text = "$ " + temp.ToString();
            }
        }

        private void infonavit_TextChanged_1(object sender, System.EventArgs e)
        {
            if (!infonavit.Text.Equals("") && !salario_mensual.Text.Equals(""))
            {
                Double pago = Double.Parse(salario_mensual.Text);
                Double temp = (Double.Parse(infonavit.Text) * pago) / 100;
                leyp3.Text = "$ " + temp.ToString();
            }
        }

        private void rvc_TextChanged_1(object sender, System.EventArgs e)
        {
            if (!rvc.Text.Equals("") && !salario_mensual.Text.Equals(""))
            {
                Double pago = Double.Parse(salario_mensual.Text);
                Double temp = (Double.Parse(rvc.Text) * pago) / 100;
                leyp4.Text = "$ " + temp.ToString();
            }
        }

        //input functions empresa
        private void sgmm_TextChanged_1(object sender, System.EventArgs e)
        {
            if (!sgmm.Text.Equals("") && !salario_mensual.Text.Equals(""))
            {
                Double pago = Double.Parse(salario_mensual.Text);
                Double temp = (Double.Parse(sgmm.Text) * pago) / 100;
                emp1.Text = "$ " + temp.ToString();
            }
        }

        private void vd_TextChanged_1(object sender, System.EventArgs e)
        {
            if (!vd.Text.Equals("") && !salario_mensual.Text.Equals(""))
            {
                Double pago = Double.Parse(salario_mensual.Text);
                Double temp = (Double.Parse(vd.Text) * pago) / 100;
                emp2.Text = "$ " + temp.ToString();
            }
        }

        private void comedor_TextChanged(object sender, System.EventArgs e)
        {
        }

        private void svida_TextChanged_1(object sender, System.EventArgs e)
        {
        }

        //calculador
        private void nut_Click(object sender, EventArgs e)
        {
            Boolean validation = true;
            //validation
            if (salario_mensual.Text.Equals(""))
            {
                validation = false;
            }
            //validation
            if(validation == true)
            {
                action();
            }
        }

        public void action()
        {
            //general
            Double pago = Double.Parse(salario_mensual.Text);
            //valores ley
            Double strAginaldo = 0;
            if (Double.TryParse(agunaldo.Text, out strAginaldo))
            {
                strAginaldo = (strAginaldo*pago) / 100;
            }
            Double strVacaciones = 0;
            if (Double.TryParse(vacaciones.Text, out strVacaciones))
            {
                strVacaciones = (strVacaciones * pago) / 100;
            }
            Double strInfonavit = 0;
            if (Double.TryParse(infonavit.Text, out strInfonavit))
            {
                strInfonavit = (strInfonavit * pago) / 100;
            }
            Double strRvc = 0;
            if (Double.TryParse(rvc.Text, out strRvc))
            {
                strRvc = (strRvc * pago) / 100;
            }
            //valores empresa
            Double strSgmm = 0;
            if (Double.TryParse(sgmm.Text, out strSgmm))
            {
                strSgmm = (strSgmm * pago) / 100;
            }
            Double strVd = 0;
            if (Double.TryParse(vd.Text, out strVd))
            {
                strVd = (strVd * pago) / 100;
            }
            Double strComedor = 0;
            if (Double.TryParse(comedor.Text, out strComedor))
            {
            }
            Double strSvida = 0;
            if (Double.TryParse(svida.Text, out strSvida))
            {
            }
            //Valores totales
            Double tempLey = strAginaldo + strVacaciones + strInfonavit + strRvc;
            Double tempEmpresa = strSgmm + strVd + strComedor + strSvida;
            Double total = tempLey + tempEmpresa + pago;

            salario_bruto.Text = salario_mensual.Text;
            ley.Text = tempLey.ToString();
            empresa.Text = tempEmpresa.ToString();
            mensual.Text = total.ToString();
        }
    }
}
