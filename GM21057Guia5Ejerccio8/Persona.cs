using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM21057Guia5Ejerccio8
{
    internal class Persona
    {
        private string nombres, apellidos;

        public Persona() { }

        public Persona(string nombres, string apellidos)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;

        }

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        //Metodo que contiene el docente con la mayor cantidad de alumnos
        public void DocentesConMasAlumnos(int maestro1, int maestro2, int maestro3, int maestro4, int maestro5, int[] docente, Label labelPrimerDocente, TextBox textBoxMasAlumno, Label labelSegundoDocente, Label labelTercerDocente)
        {
            int docenteMasALumno1 = 0;
            int docenteMasALumno2 = 0;
            int docenteMasALumno3 = 0;

            //Primer Docente con mas alumnos
            if ((maestro1 > maestro2) && (maestro1 > maestro3) && (maestro1 > maestro4) && (maestro1 > maestro5))
            {
                docenteMasALumno1 = maestro1;
                labelPrimerDocente.Text = "Katherine Rosales Morales Molina";
                textBoxMasAlumno.Text = "Katherine Rosales Morales Molina";
            }
            else if ((maestro2 > maestro1) && (maestro2 > maestro3) && (maestro2 > maestro4) && (maestro2 > maestro5))
            {
                docenteMasALumno1 = maestro2;
                labelPrimerDocente.Text = "Roberto Carlos Cruz Paredes";
                textBoxMasAlumno.Text = "Roberto Carlos Cruz Paredes";
            }
            else if ((maestro3 > maestro1) && (maestro3 > maestro2) && (maestro3 > maestro4) && (maestro3 > maestro5))
            {
                docenteMasALumno1 = maestro3;
                labelPrimerDocente.Text = "Rosa Michelle Pereira Gonzales";
                textBoxMasAlumno.Text = "Rosa Michelle Pereira Gonzales";
            }
            else if ((maestro4 > maestro1) && (maestro4 > maestro2) && (maestro4 > maestro3) && (maestro4 > maestro5))
            {
                docenteMasALumno1 = maestro4;
                labelPrimerDocente.Text = "Heriberto Ramirez Rivas Monge";
                textBoxMasAlumno.Text = "Heriberto Ramirez Rivas Monge";
            }
            else if ((maestro4 > maestro1) && (maestro4 > maestro2) && (maestro4 > maestro3) && (maestro4 > maestro5))
            {
                docenteMasALumno1 = maestro5;
                textBoxMasAlumno.Text = "Samira Arianna Rodriguez Gonzales";
                labelPrimerDocente.Text = "Samira Arianna Rodriguez Gonzales";
            }

            //Segundo Docente con mas alumnos

            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[0] >= docenteMasALumno2 && docente[0] < docenteMasALumno1)
                {
                    docenteMasALumno2 = docente[0];
                    labelSegundoDocente.Text = "Katherine Rosales Morales Molina";
                }
            }
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[1] >= docenteMasALumno2 && docente[1] < docenteMasALumno1)
                {
                    docenteMasALumno2 = docente[1];
                    labelSegundoDocente.Text = "Roberto Carlos Cruz Paredes";
                }
            }
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[2] >= docenteMasALumno2 && docente[2] < docenteMasALumno1)
                {
                    docenteMasALumno2 = docente[2];
                    labelSegundoDocente.Text = "Rosa Michelle Pereira Gonzales";
                }
            }
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[3] >= docenteMasALumno2 && docente[3] < docenteMasALumno1)
                {
                    docenteMasALumno2 = docente[3];
                    labelSegundoDocente.Text = "Heriberto Ramirez Rivas Monge";
                }
            }
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[4] >= docenteMasALumno2 && docente[4] < docenteMasALumno1)
                {
                    docenteMasALumno2 = docente[4];
                    labelSegundoDocente.Text = "Samira Arianna Rodriguez Gonzales";
                }
            }


            //Tercer Docente con mas alumnos
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[0] >= docenteMasALumno3 && docente[0] < docenteMasALumno2)
                {
                    docenteMasALumno3 = docente[0];
                    labelTercerDocente.Text = "Katherine Rosales Morales Molina";
                }
            }
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[1] >= docenteMasALumno3 && docente[1] < docenteMasALumno2)
                {
                    docenteMasALumno3 = docente[1];
                    labelTercerDocente.Text = "Roberto Carlos Cruz Paredes";
                }
            }
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[2] >= docenteMasALumno3 && docente[2] < docenteMasALumno2)
                {
                    docenteMasALumno3 = docente[2];
                    labelTercerDocente.Text = "Rosa Michelle Pereira Gonzales";
                }
            }

            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[3] >= docenteMasALumno3 && docente[3] < docenteMasALumno2)
                {
                    docenteMasALumno3 = docente[3];
                    labelTercerDocente.Text = "Heriberto Ramirez Rivas Monge";
                }
            }
            for (int i = 0; i < docente.Length; i++)
            {
                if (docente[4] >= docenteMasALumno3 && docente[4] < docenteMasALumno2)
                {
                    docenteMasALumno3 = docente[4];
                    labelTercerDocente.Text = "Samira Arianna Rodriguez Gonzales";
                }
            }

        }
    }
}

