namespace GestionMatos
{
    class IdInter
    {
        public int id;
        public string nominter;
        public string dateinter;
        public string commentaire;
        public string nommat;
        public string typemat;
        public string nomclient;
        public string site;




        public IdInter(int leid, string lenominter, string lainterdate, string lecommentaire, string lenommat, string letypemat, string lenomclient, string lesite)
        {
            this.id = leid;
            this.nominter = lenominter;
            this.dateinter = lainterdate;
            this.commentaire = lecommentaire;
            this.nommat = lenommat;
            this.typemat = letypemat;
            this.nomclient = lenomclient;
            this.site = lesite;


        }
        public override string ToString()
        {
            return this.nominter;
            return this.dateinter;
            return this.commentaire;
            return this.nommat;
            return this.typemat;
            return this.nomclient;
            return this.site;


        }
    }
}