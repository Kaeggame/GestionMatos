namespace GestionMatos
{
    class IdMat
    {
        public int id;
        public string nommat;
        public string numserie;
        public string typemat;
        public string dateinstall;
        public string desc;
        public string mtbf;
        public string nomclient;



        public IdMat(int leid, string lenommat, string lenumserie, string letypemat, string ladateinstall, string ladesc, string lemtbf, string lenomclient)
        {
            this.id = leid;
            this.nommat = lenommat;
            this.numserie = lenumserie;
            this.dateinstall = ladateinstall;
            this.typemat = letypemat;
            this.desc = ladesc;
            this.mtbf = lemtbf;
            this.nomclient = lenomclient;
        }
        public override string ToString()
        {
            return this.nommat;
            return this.numserie;
            return this.dateinstall;
            return this.typemat;
            return this.desc;
            return this.mtbf;
            return this.nomclient;
        }
    }
}