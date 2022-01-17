namespace GestionMatos
{
    class IdClient
    {
        public int id;
        public string nom;
        public string mail;
        public string tele;


        public IdClient(int leid, string lenom, string email, string tel)
        {
            this.id = leid;
            this.nom = lenom;
            this.mail = email;
            this.tele = tel;
        }
        public override string ToString()
        {
            return this.nom;
            return this.mail;
            return this.tele;
        }
    }
}