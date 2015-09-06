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
    public partial class AFN : Form
    {
        public static ArrayList transiciones = new ArrayList();
        public static string[] estadosAceptacion;
        public static string[] simbolos;
        public static string[] estados;
        public static string inicio;
        public AFN(ArrayList transicio,string[] estadosA,string []sim, string [] esta, string ini)
        {
            
            
            InitializeComponent();
            transiciones = transicio;
            estadosAceptacion=estadosA;
            simbolos=sim;
            estados=esta;
            inicio=ini;
            for(int a=0;a<simbolos.Length;a++)
            {
                DataGridViewColumn columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna.Name = (string)simbolos[a];
                columna.Width = 30;

                dataGridView1.Columns.Add(columna);
            }
            DataGridViewColumn columnaf = new DataGridViewColumn(new DataGridViewTextBoxCell());
            columnaf.Name = "F";
            dataGridView1.Columns.Add(columnaf);

            for (int b = 0; b < estados.Length; b++)
            {
                dataGridView1.Rows.Add();

                dataGridView1["QΣ", b].Value = estados[b];
               
            }
           
            agregarDatos();

        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            AFD_sin_renombramiento form = new AFD_sin_renombramiento(transiciones, estadosAceptacion, simbolos, estados, inicio, this.dataGridView1);
            form.Show();
            this.Visible = false;
        }
        public void agregarDatos()
        {

            for (int tablaEstadosIniciales = 0; tablaEstadosIniciales < estados.Length; tablaEstadosIniciales++)
            {
                for (int f = 0; f < estadosAceptacion.Length; f++)
                {
                    if (estados[tablaEstadosIniciales].Equals(estadosAceptacion[f]))
                    {
                        dataGridView1[simbolos.Length + 1, tablaEstadosIniciales].Value = "1";
                    }
                }
                    for (int transicionesContador = 0; transicionesContador < transiciones.Count; transicionesContador++)
                    {
                        Transicion transicion = (Transicion)transiciones[transicionesContador];
                        if (transicion.getestadoInicio().Equals(dataGridView1["QΣ", tablaEstadosIniciales].Value))
                        {
                            string estadoFinal = transicion.getestadoestadoFinal();
                            int indiceSimbolo = 0;
                            for (int a = 0; a < simbolos.Length; a++)
                            {
                                if (simbolos[a].Equals(transicion.getsimbolo()))
                                {
                                    indiceSimbolo = a;
                                    a = simbolos.Length;
                                }
                            }
                            if (dataGridView1[indiceSimbolo + 1, tablaEstadosIniciales].Value == null)
                            {
                                dataGridView1[indiceSimbolo + 1, tablaEstadosIniciales].Value = estadoFinal;
                            }
                            else
                            {
                                string valor = (string)dataGridView1[indiceSimbolo + 1, tablaEstadosIniciales].Value;
                                valor += "," + estadoFinal;
                                dataGridView1[indiceSimbolo + 1, tablaEstadosIniciales].Value = valor;
                            }

                        }




                    }
               
                                   

            }

            
       
        }

    }
}
