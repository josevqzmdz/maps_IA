using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maps_IA
{
    public partial class Form1 : Form
    {
        // inicializacion de los nodos
        public static node aquila = new node("aquila");
        public static node maruata = new node("maruata");
        public static node tepalcatepec = new node("tepalcatepec");
        public static node apatzingan = new node("apatzingan");
        public static node nueva_italia = new node("nueva italia");
        public static node lazaro_cardenas = new node("lazaro cardenas");
        public static node los_reyes = new node("los reyes");
        public static node uruapan = new node("uruapan");
        public static node sahuayo = new node("sahuayo");
        public static node zamora = new node("zamora");
        public static node zacapu = new node("zacapu");
        public static node patzcuaro = new node("patzcuaro");
        public static node morelia = new node("morelia");
        public static node cd_hidalgo = new node("ciudad hidalgo");

        // list of all nodes inside graph
        public static List<node> list = new List<node> {
            aquila, maruata, tepalcatepec, apatzingan, nueva_italia,
            lazaro_cardenas, los_reyes, uruapan, sahuayo, zamora,
            zacapu, patzcuaro, morelia, cd_hidalgo
        };

        public Form1()
        {
            InitializeComponent();
            // vertices de aquila
            aquila.neighbor.Add(maruata);
            aquila.neighbor.Add(tepalcatepec);
            // aquila - maruata
            aquila.vertexes.Add(new vertex(aquila, maruata, 2));
            // aquila - tepalcatepec
            aquila.vertexes.Add(new vertex(aquila, tepalcatepec, 3));

            // vertices de maruata
            maruata.neighbor.Add(aquila);
            maruata.neighbor.Add(lazaro_cardenas);
            // marata - aquila
            maruata.vertexes.Add(new vertex(maruata, aquila, 2));
            // maruata - lazaro cardenas
            maruata.vertexes.Add(new vertex(maruata, lazaro_cardenas, 3));

            // vertices de lazaro cardenas
            lazaro_cardenas.neighbor.Add(maruata);
            lazaro_cardenas.neighbor.Add(nueva_italia);
            // lazaro - maruata
            lazaro_cardenas.vertexes.Add(new vertex(lazaro_cardenas, maruata, 3));
            // lazaro - nueva italia
            lazaro_cardenas.vertexes.Add(new vertex(lazaro_cardenas, nueva_italia, 5));

            // vertices de nueva italia
            nueva_italia.neighbor.Add(apatzingan);
            nueva_italia.neighbor.Add(lazaro_cardenas);
            nueva_italia.neighbor.Add(patzcuaro);
            // italia - lazaro
            nueva_italia.vertexes.Add(new vertex(nueva_italia, lazaro_cardenas, 5));
            // italia - apatzingan
            nueva_italia.vertexes.Add(new vertex(nueva_italia, apatzingan, 3));
            // italia - patzcuaro
            nueva_italia.vertexes.Add(new vertex(nueva_italia, patzcuaro, 3));

            // vertices de apatzingan
            apatzingan.neighbor.Add(nueva_italia);
            apatzingan.neighbor.Add(tepalcatepec);
            apatzingan.neighbor.Add(uruapan);
            // apatzingan - nueva italia
            apatzingan.vertexes.Add(new vertex(apatzingan, nueva_italia, 3));
            // apatzingan - tepalcatepec
            apatzingan.vertexes.Add(new vertex(apatzingan, tepalcatepec, 3));
            // apatzingan - uruapan
            apatzingan.vertexes.Add(new vertex(apatzingan, uruapan, 3));

            // vertices de tepalcatepec
            tepalcatepec.neighbor.Add(los_reyes);
            tepalcatepec.neighbor.Add(aquila);
            tepalcatepec.neighbor.Add(apatzingan);
            // tepa - aquila
            tepalcatepec.vertexes.Add(new vertex(tepalcatepec, aquila, 3));
            // tepa - los reyes
            tepalcatepec.vertexes.Add(new vertex(tepalcatepec, los_reyes, 4));
            // tepa - apatzingan
            tepalcatepec.vertexes.Add(new vertex(tepalcatepec, apatzingan, 3));

            // vertices de los reyes
            los_reyes.neighbor.Add(tepalcatepec);
            los_reyes.neighbor.Add(sahuayo);
            los_reyes.neighbor.Add(uruapan);
            // los reyes - tepa
            los_reyes.vertexes.Add(new vertex(los_reyes, tepalcatepec, 3));
            // reyes - uruapan
            los_reyes.vertexes.Add(new vertex(los_reyes, uruapan, 2));
            // reyes - sahuayo
            los_reyes.vertexes.Add(new vertex(los_reyes, sahuayo, 3));

            // vertices de uruapan
            uruapan.neighbor.Add(los_reyes);
            uruapan.neighbor.Add(zamora);
            uruapan.neighbor.Add(apatzingan);
            // uruapan - apatzingan
            uruapan.vertexes.Add(new vertex(uruapan, apatzingan, 3));
            // uruapan - los reyes
            uruapan.vertexes.Add(new vertex(uruapan, los_reyes, 2));
            // uruapan - zamora
            uruapan.vertexes.Add(new vertex(uruapan, zamora, 3));

            // vertices sahuayo
            sahuayo.neighbor.Add(los_reyes);
            sahuayo.neighbor.Add(zamora);
            // sahuayo - los reyes
            sahuayo.vertexes.Add(new vertex(sahuayo, los_reyes, 3));
            // sahuayo - zamora
            sahuayo.vertexes.Add(new vertex(sahuayo, zamora, 3));

            // vertices de zamora
            zamora.neighbor.Add(sahuayo);
            zamora.neighbor.Add(uruapan);
            zamora.neighbor.Add(zacapu);
            // zamora - sahuayo
            zamora.vertexes.Add(new vertex(zamora, sahuayo, 3));
            // zamora - uruapan
            zamora.vertexes.Add(new vertex(zamora, uruapan, 3));
            // zamora - zacapu
            zamora.vertexes.Add(new vertex(zamora, zacapu, 4));

            // vertices de zacapu
            zacapu.neighbor.Add(zamora);
            zacapu.neighbor.Add(patzcuaro);
            zacapu.neighbor.Add(morelia);
            // zacapu - zamora
            zacapu.vertexes.Add(new vertex(zacapu, zamora, 4));
            // zacapu - patzcuaro
            zacapu.vertexes.Add(new vertex(zacapu, patzcuaro, 2));
            // zacapu - morelia
            zacapu.vertexes.Add(new vertex(zacapu, morelia, 2));

            // vertices de patzcuaro
            patzcuaro.neighbor.Add(nueva_italia);
            patzcuaro.neighbor.Add(zacapu);
            patzcuaro.neighbor.Add(morelia);
            // patz - zacapu
            patzcuaro.vertexes.Add(new vertex(patzcuaro, zacapu, 2));
            // patz - nueva italia
            patzcuaro.vertexes.Add(new vertex(patzcuaro, nueva_italia, 3));
            // patz - morelia
            patzcuaro.vertexes.Add(new vertex(patzcuaro, morelia, 2));

            // vertices de morelia
            morelia.neighbor.Add(zacapu);
            morelia.neighbor.Add(patzcuaro);
            morelia.neighbor.Add(cd_hidalgo);
            // morelia - zacapu
            morelia.vertexes.Add(new vertex(morelia, zacapu, 2));
            // morelia - patzcuaro
            morelia.vertexes.Add(new vertex(morelia, patzcuaro, 2));
            // morelia - cd hidalgo
            morelia.vertexes.Add(new vertex(morelia, cd_hidalgo, 3));

            // cd hidalgo
            cd_hidalgo.neighbor.Add(morelia);
            cd_hidalgo.vertexes.Add(new vertex(cd_hidalgo, morelia, 2));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logic lo = new logic();
            var result = lo.DFS(list, patzcuaro);
            foreach(var item in result)
            {
                Console.WriteLine(item.name + item.distance.ToString());
            }
        }
    }
}
