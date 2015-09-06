using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AFN_a_AFD.modelo;
using System.Collections;
namespace AFN_a_AFD
{
   
    public partial class AFD_sin_renombramiento : Form
    {
        public static ArrayList transiciones = new ArrayList();
        public static string[] estadosAceptacion;
        public static string[] simbolos;
        public static List<string> estados;
        public static string inicio;

        public AFD_sin_renombramiento(ArrayList transicio, string[] estadosA, string[] sim, string[] esta, string ini, DataGridView grafico)
        {
            transiciones = transicio;
            estadosAceptacion = estadosA;
            simbolos = sim;
            estados =new List<string>( esta);
            inicio = ini;
            
            InitializeComponent();
         
            agregarDatos();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            AFD_con_renombramiento form = new AFD_con_renombramiento();
            form.Show();
            this.Visible = false;
        }
        public void agregarDatos()
        {
            for (int a = 0; a < simbolos.Length; a++)
            {
                DataGridViewColumn columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                columna.Name = (string)simbolos[a];
                columna.Width = 30;

                dataGridView1.Columns.Add(columna);
            }
            DataGridViewColumn columnaf = new DataGridViewColumn(new DataGridViewTextBoxCell());
            columnaf.Name = "F";
            dataGridView1.Columns.Add(columnaf);

            for (int b = 0; b < estados.Count(); b++)
            {
                dataGridView1.Rows.Add();

                dataGridView1["QΣ", b].Value = estados[b];

            }

            for (int tablaEstadosIniciales = 0; tablaEstadosIniciales < estados.Count(); tablaEstadosIniciales++)
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

            transAFD();

        }

        public void transAFD()
        {
            int contador = estados.Count();
            for (int tablaEstadosIniciales = 0; tablaEstadosIniciales < estados.Count(); tablaEstadosIniciales++)
            {
                for (int a = 0; a < simbolos.Length; a++)
                {
                    if (dataGridView1[a + 1, tablaEstadosIniciales].Value != null)
                    {
                        string [] cad = dataGridView1[a + 1, tablaEstadosIniciales].Value.ToString().Split(',');
                        if (cad.Length > 1)
                        {
                            Transicion transicion = new Transicion(estados[tablaEstadosIniciales], dataGridView1[a + 1, tablaEstadosIniciales].Value.ToString(), simbolos[a]);
                            transiciones.Add(transicion);
                            estados.Add(dataGridView1[a + 1, tablaEstadosIniciales].Value.ToString());
                            dataGridView1.Rows.Add();
                            
                           dataGridView1["QΣ", contador].Value = dataGridView1[a + 1, tablaEstadosIniciales].Value.ToString();
                           contador++;
                           estados.Add(dataGridView1[a + 1, tablaEstadosIniciales].Value.ToString());
                          // agre(contador, cad);
                        }
                    }
                   
                }
            }
           
        }

        public void agre(int PosicionRealFila,string []cad)
        {
            for (int a = 0; a < cad.Length; a++)
            {
                int posicionEstado = estados.IndexOf(cad[a]);
                for (int s = 0; s < simbolos.Length; s++)
                {
                    if (dataGridView1[s,posicionEstado].Value != null)
                    {
                        if (dataGridView1[s, PosicionRealFila].Value == null)
                        {
                            dataGridView1[s, PosicionRealFila].Value = dataGridView1[posicionEstado, s].Value;
                        }
                        else
                        {
                            string valor = (string)dataGridView1[posicionEstado, s].Value;
                            valor += dataGridView1[s, PosicionRealFila].Value + "," + valor;
                            dataGridView1[s, PosicionRealFila].Value = valor;
                        }
                    }
                }
            }
            

        }
    }
}
