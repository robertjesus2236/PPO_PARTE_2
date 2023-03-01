namespace poopart2
{
    public partial class Form1 : Form
    {
        Persona p = new Persona(); //Objeto creado
        public Form1()
        {
            InitializeComponent();
        }

        private void Llamar_Click(object sender, EventArgs e)
        {
            p.Pais = "Venezuela";
            p.Nid = "+584120000000";
            MessageBox.Show(p.Nid);
        }
    }
}