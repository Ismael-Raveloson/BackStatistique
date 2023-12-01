using System.Data.SqlClient;
namespace statistique
{
    public class StatistiqueModel
    {
        public string equipe{get;set;}
        public string ligue{get;set;}
        public Decimal buts{get;set;}  
        public Decimal tirMatch{get;set;}
        public Decimal cartonJaune{get;set;}
        public Decimal cartonRouge{get;set;}
        public Decimal possession{get;set;}
        public Decimal passeReussie{get;set;}
        public Decimal aerienGagne{get;set;}
        public Decimal note {get;set;}
        public Decimal tacleMatch {get;set;}
        public Decimal interceptionMatch {get;set;}
        public Decimal fauteMatch {get;set;}
        public Decimal horsJeuMatch {get;set;}
        public Decimal tireCadreMatch{get;set;}
        public Decimal dribbleMatch{get;set;}


        


        

        public StatistiqueModel()
        {

        }

        public StatistiqueModel(string equipe,string ligue,Decimal buts,Decimal tirMatch,Decimal cartonJaune,Decimal cartonRouge,Decimal possession,Decimal passeReussie,Decimal aerienGagne,Decimal note)
        {
            this.equipe = equipe;
            this.ligue= ligue;
            this.buts = buts;
            this.tirMatch = tirMatch;
            this.cartonJaune = cartonJaune;
            this.cartonRouge = cartonRouge;
            this.possession = possession;
            this.passeReussie = passeReussie;
            this.aerienGagne = aerienGagne;
            this.note = note;
        }
        

        //liste de StatistiqueModelEquipeGenerale

    public List<StatistiqueModel> StatGeneral()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeGeneralGeneral";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            buts = reader.GetDecimal(reader.GetOrdinal("buts")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            cartonJaune = reader.GetDecimal(reader.GetOrdinal("cartonJaune")),
                            cartonRouge = reader.GetDecimal(reader.GetOrdinal("cartonRouge")),
                            possession = reader.GetDecimal(reader.GetOrdinal("possession")),
                            passeReussie = reader.GetDecimal(reader.GetOrdinal("passesReussies")),
                            aerienGagne = reader.GetDecimal(reader.GetOrdinal("aerienGagnes")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),
                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    }

    public List<StatistiqueModel> StatGeneralDomicile()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeGeneralDomicile";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            buts = reader.GetDecimal(reader.GetOrdinal("buts")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            cartonJaune = reader.GetDecimal(reader.GetOrdinal("cartonJaune")),
                            cartonRouge = reader.GetDecimal(reader.GetOrdinal("cartonRouge")),
                            possession = reader.GetDecimal(reader.GetOrdinal("possession")),
                            passeReussie = reader.GetDecimal(reader.GetOrdinal("passesReussies")),
                            aerienGagne = reader.GetDecimal(reader.GetOrdinal("aerienGagnes")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),
                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    }

    public List<StatistiqueModel> StatGeneralExterieur()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeGeneralExterieur";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            buts = reader.GetDecimal(reader.GetOrdinal("buts")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            cartonJaune = reader.GetDecimal(reader.GetOrdinal("cartonJaune")),
                            cartonRouge = reader.GetDecimal(reader.GetOrdinal("cartonRouge")),
                            possession = reader.GetDecimal(reader.GetOrdinal("possession")),
                            passeReussie = reader.GetDecimal(reader.GetOrdinal("passesReussies")),
                            aerienGagne = reader.GetDecimal(reader.GetOrdinal("aerienGagnes")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),
                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    }

    public List<StatistiqueModel> StatDefDom()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeDefenseDomicile";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            tacleMatch = reader.GetDecimal(reader.GetOrdinal("tacleMatch")),
                            interceptionMatch = reader.GetDecimal(reader.GetOrdinal("interceptionMatch")),
                            fauteMatch = reader.GetDecimal(reader.GetOrdinal("fauteMatch")),
                            horsJeuMatch = reader.GetDecimal(reader.GetOrdinal("horsJeuxMatch")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),
                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    }


    public List<StatistiqueModel> StatDefExt()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeDefenseExterieur";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            tacleMatch = reader.GetDecimal(reader.GetOrdinal("tacleMatch")),
                            interceptionMatch = reader.GetDecimal(reader.GetOrdinal("interceptionMatch")),
                            fauteMatch = reader.GetDecimal(reader.GetOrdinal("fauteMatch")),
                            horsJeuMatch = reader.GetDecimal(reader.GetOrdinal("horsJeuxMatch")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),
                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    }

    public List<StatistiqueModel> StatDefGen()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeDefenseGeneral";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            tacleMatch = reader.GetDecimal(reader.GetOrdinal("tacleMatch")),
                            interceptionMatch = reader.GetDecimal(reader.GetOrdinal("interceptionMatch")),
                            fauteMatch = reader.GetDecimal(reader.GetOrdinal("fauteMatch")),
                            horsJeuMatch = reader.GetDecimal(reader.GetOrdinal("horsJeuxMatch")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),
                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    }


    public List<StatistiqueModel> StatAttDom()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeAttaquedomicile";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            tireCadreMatch = reader.GetDecimal(reader.GetOrdinal("tirCadreMatch")),
                            dribbleMatch = reader.GetDecimal(reader.GetOrdinal("dribbleMatch")),
                            fauteMatch = reader.GetDecimal(reader.GetOrdinal("fauteSubieMatch")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    } 


    public List<StatistiqueModel> StatAttExt()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeAttaqueExterieur";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            tireCadreMatch = reader.GetDecimal(reader.GetOrdinal("tirCadreMatch")),
                            dribbleMatch = reader.GetDecimal(reader.GetOrdinal("dribbleMatch")),
                            fauteMatch = reader.GetDecimal(reader.GetOrdinal("fauteSubieMatch")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    } 


    public List<StatistiqueModel> StatAttGen()
    {
        List<StatistiqueModel> statistiques = new List<StatistiqueModel>();
        string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=statistique;Trusted_Connection=True;";
        string query = "SELECT * FROM statsEquipeAttaqueGeneral";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        StatistiqueModel stat = new StatistiqueModel
                        {
                            equipe = reader.GetString(reader.GetOrdinal("equipe")),
                            ligue  = reader.GetString(reader.GetOrdinal("ligue")),
                            tirMatch = reader.GetDecimal(reader.GetOrdinal("tirMatch")),
                            tireCadreMatch = reader.GetDecimal(reader.GetOrdinal("tirCadreMatch")),
                            dribbleMatch = reader.GetDecimal(reader.GetOrdinal("dribbleMatch")),
                            fauteMatch = reader.GetDecimal(reader.GetOrdinal("fauteSubieMatch")),
                            note = reader.GetDecimal(reader.GetOrdinal("note")),                            
                            
                        };

                        statistiques.Add(stat);
                    }
                }
            }
        }

        return statistiques;
    } 



}
}