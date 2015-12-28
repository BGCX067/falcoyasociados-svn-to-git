//-----------------------------------------------------------------------------
// Navegar por una tabla                                            (21/Mar/07)
// En el constructor se indicará la tabla a usar
//
// ©Guillermo 'guille' Som, 2007
//-----------------------------------------------------------------------------
using System;
using System.Data;
using System.IO;
using System.Drawing;

    public class TablaNavegar
    {

        private DataTable laTabla;
        private int laFila;

        private int totalFilas
        {
            get
            {
                return laTabla.Rows.Count - 1;
            }
        }

        /// <summary>
        /// El constructor que recibe la tabla a usar
        /// </summary>
        /// <param name="tabla">
        /// La tabla por la que se navegará
        /// </param>
        /// <remarks>
        /// 20/Feb/2007
        /// </remarks>
        public TablaNavegar(DataTable tabla)
        {
            laTabla = tabla;
            laFila = 0;
        }

        public void ActualizarTabla(DataTable tabla)
        {
            laTabla = tabla;
            if (laFila > totalFilas)
            {
                laFila = totalFilas;
            }
            if (laFila < 0)
            {
                laFila = 0;
            }
        }

        // Los cuatro métodos para navegar por las filas
        public DataRow Primera()
        {
            laFila = 0;
            return laTabla.Rows[laFila];
        }

        public DataRow Ultima()
        {
            laFila = totalFilas;
            return laTabla.Rows[laFila];
        }

        public DataRow Siguiente()
        {
            laFila += 1;
            if (laFila > totalFilas)
            {
                laFila = totalFilas;
            }
            return laTabla.Rows[laFila];
        }

        public DataRow Anterior()
        {
            laFila -= 1;
            if (laFila < 0)
            {
                laFila = 0;
            }
            return laTabla.Rows[laFila];
        }

        /// <summary>
        /// Devuelve un DataRow con la fila actual.
        /// </summary>
        /// <value>
        /// Devuelve un DataRow con la fila actual
        /// </value>
        /// <returns>
        /// Un objeto DataRow con la fila actual.
        /// </returns>
        /// <remarks></remarks>
        public DataRow FilaActual
        {
            get
            {
                if (this.totalFilas >= 0)
                {
                    return laTabla.Rows[laFila];
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que devuelve
        /// el índidce de la fila actual.
        /// </summary>
        /// <value>
        /// El índice de la fila actual
        /// </value>
        /// <returns>
        /// El valor del índice de la fila actual.
        /// </returns>
        /// <remarks>
        /// 20/Feb/2007
        /// </remarks>
        public int NumeroFilaActual
        {
            get
            {
                return laFila;
            }
        }

        /// <summary>
        /// Propiedad de solo lectura que devuelve
        /// el índice de la última fila.
        /// </summary>
        /// <value>
        /// El índice de la última fila
        /// </value>
        /// <returns>
        /// El valor del índice de la última fila.
        /// </returns>
        /// <remarks>
        /// 20/Feb/2007
        /// </remarks>
        public int NumeroUltimaFila
        {
            get
            {
                return totalFilas;
            }
        }

        /// <summary>
        /// Indizador que devuelve la fila indicada
        /// </summary>
        /// <param name="index">
        /// El índice de la fila a devolver.
        /// El índice indicado no altera el valor del número de la fila actual.
        /// </param>
        /// <value>
        /// La fila con el índice indicado.
        /// </value>
        /// <returns>
        /// Un objeto DataRow con la fila indicada.
        /// </returns>
        /// <remarks>
        /// 20/Feb/2007
        /// </remarks>
        public DataRow this[int index]
        {
            get
            {
                if (index < 0)
                {
                    index = 0;
                }
                if (index > totalFilas)
                {
                    index = totalFilas;
                }
                return laTabla.Rows[index];
            }
        }

        // Métodos compartidos
        public static byte[] Image2Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            // Cerrarlo y volverlo a abrir
            // o posicionarlo en el primer byte
            //fs.Close();
            //fs = new FileStream(sTemp, FileMode.Open, FileAccess.Read);
            fs.Position = 0;
            //
            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }

        public static Image Bytes2Image(byte[] bytes)
        {
            if (bytes == null) return null;
            //
            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }
    }

