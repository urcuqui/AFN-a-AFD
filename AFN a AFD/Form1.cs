using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AFN_a_AFD.modelo;
namespace AFN_a_AFD
{
    public partial class Form1 : Form
    {
     public static string[] estadosAceptacion;
     public static string inicio = null;
     public static ArrayList transiciones = null;
     public static string[] simbolos;
     public static string[] esta;
     
        public Form1()
        {
            transiciones = new ArrayList();
            InitializeComponent();
            estadosAceptacion = null;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_transiciones_Click(object sender, EventArgs e)
        {

            label_formula.Visible = true;
            label_q.Visible = true;
            label_qi.Visible = true;
            label_s.Visible = true;
            btn_finalizar.Visible = true;
            btn_agregarAFuncion.Visible = true;
            list_q.Visible = true;
            list_qi.Visible = true;
            list_s.Visible = true;
            btn_transiciones.Visible = false;

            string alfabeto = txt_alfabeto.Text;
            simbolos = alfabeto.Split(',');
            for (int a = 0; a < simbolos.Length; a++)
            {
                list_s.Items.Add(simbolos[a]);
            }
            string estados = txt_estados.Text;
           esta = estados.Split(',');
            for (int a = 0; a < esta.Length; a++)
            {
                list_q.Items.Add(esta[a]);
                list_qi.Items.Add(esta[a]);
            }
            string estadosAcepta = txt_aceptacion.Text;
            estadosAceptacion = estadosAcepta.Split(',');
            inicio = txt_inicio.Text;
        }

        private void btn_agregarAFuncion_Click(object sender, EventArgs e)
        {
            
            string q=(string)list_q.SelectedItem;
            string s = (string)list_s.SelectedItem;
            string qi = (string)list_qi.SelectedItem;
            Transicion transicion = new Transicion(q, qi, s);
           // transiciones.Add(new modelo.Transicion(q,qi,s));
            transiciones.Add(transicion);
            MessageBox.Show("Transicion agregada" + " ∆("+q+","+s+")"+"="+qi);
            
            

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {

            AFN form = new AFN(transiciones,estadosAceptacion,simbolos,esta,inicio);
            form.Show();
            this.Visible = false;
        }

       
    }
}
