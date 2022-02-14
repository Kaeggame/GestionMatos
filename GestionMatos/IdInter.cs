namespace GestionMatos
{
    class IdInter
    {
        public int id;
        public string nominter;
        public string dateinter;
        public string commentaire;




        public IdInter(int leid, string lenominter, string lainterdate, string lecommentaire)
        {
            this.id = leid;
            this.nominter = lenominter;
            this.dateinter = lainterdate;
            this.commentaire = lecommentaire;

        }
        public override string ToString()
        {
            return this.nominter;
            return this.dateinter;
            return this.commentaire;

        }
    }
}