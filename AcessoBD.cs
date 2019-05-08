using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PrototipoPulseira
{
    class AcessoBD
    {
        private static String senhasa;
        private static AcessoBD instanciaBD = new AcessoBD();
        public static String[,] users = new String[1000,2];

        private AcessoBD() {
            users[0, 0] = "q";
            users[0, 1] = "q";
            users[1, 0] = "Fernando";
            users[1, 1] = "123456";
        }

        public static AcessoBD getinstancia() {
            return instanciaBD;
        }

        public SqlConnection getconexao(){
            string conn = "Data Source=(local);Initial Catalog=natalid;Persist Security Info=True;User Id=sa;Password=sqAdmin123";
            return new SqlConnection(conn);

        }

        public SqlConnection getconexaosa()
        {
            
            string conn = "Data Source=(local);Initial Catalog=natalid;Persist Security Info=True;User Id=sa;Password="+senhasa;
            return new SqlConnection(conn);

        }

        public static void setsenhasa(String senha)
        {
            senhasa = senha;
        }



          //bd_senha=Responsavel
        public static DataTable bd_senha(String serial, String nome)
        {


            try
            {
                using (SqlConnection conexaoBD = AcessoBD.getinstancia().getconexao())


                    try
                    {

                        if (serial != "")
                        {
                            serial = " CodResponsavel=" + serial;

                            if (nome != "")
                            {
                                nome = " and NomeResponsavel=" + nome;
                            }

                        }
                        else
                        {
                            if (nome != "")
                            {
                                nome = " NomeResponsavel=" + nome;
                            }
                        }
                        conexaoBD.Open();
                        string ssql = "select * from Responsavel Where" + serial + nome;
                        SqlCommand cmdCommand = new SqlCommand(ssql, conexaoBD);
                        SqlDataAdapter daDataAdapter = new SqlDataAdapter(cmdCommand);
                        DataTable dtDatatable = new DataTable();
                        daDataAdapter.Fill(dtDatatable);
                        return dtDatatable;


                    }
                    catch (SqlException bdex)
                    {
                        throw bdex;
                    }
                    finally
                    {
                        conexaoBD.Close();
                    }

            }
            catch {

                
                
                using (SqlConnection conexaoBD = AcessoBD.getinstancia().getconexaosa())


                    try
                    {

                        if (serial != "")
                        {
                            serial = " CodResponsavel=" + serial;

                            if (nome != "")
                            {
                                nome = " and NomeResponsavel=" + nome;
                            }

                        }
                        else
                        {
                            if (nome != "")
                            {
                                nome = " NomeResponsavel=" + nome;
                            }
                        }
                        conexaoBD.Open();
                        string ssql = "select * from Responsavel Where" + serial + nome;
                        SqlCommand cmdCommand = new SqlCommand(ssql, conexaoBD);
                        SqlDataAdapter daDataAdapter = new SqlDataAdapter(cmdCommand);
                        DataTable dtDatatable = new DataTable();
                        daDataAdapter.Fill(dtDatatable);
                        return dtDatatable;

                        


                    }
                    catch (SqlException bdex)
                    {
                        throw bdex;
                    }
                    finally
                    {
                        conexaoBD.Close();
                    }

            }


        }

        public static DataTable BD_juridico(String cod, String cnpj, String nome)
        {
            using (SqlConnection conexaoBD = AcessoBD.getinstancia().getconexao())
                try
                {
                    if (cod != "")
                    {
                        cod = " CodEmpresa=" + cod;

                        if (cnpj != "")
                        {
                            cnpj = " and CNPJ=" + cnpj;
                        }


                        if (nome != "")
                        {
                            nome = " and NomeEmpresa=" + nome;
                        }



                    }
                    else
                    {
                        if (cnpj != "")
                        {
                            cnpj = " CNPJ=" + cnpj;

                            if (nome != "")
                            {
                                nome = " and NomeEmpresa=" + nome;
                            }

                        }
                        else {

                            if (nome != "")
                            {
                                nome = " NomeEmpresa=" + nome;
                            }

                        }


                    }

                    conexaoBD.Open();
                    string ssql = "select * from Empresa Where" + cod + cnpj + nome;
                    SqlCommand cmdCommand = new SqlCommand(ssql, conexaoBD);
                    SqlDataAdapter daDataAdapter = new SqlDataAdapter(cmdCommand);
                    DataTable dtDatatable = new DataTable();
                    daDataAdapter.Fill(dtDatatable);
                    return dtDatatable;


                }
                catch (SqlException bdex)
                {
                    throw bdex;
                }
                finally
                {
                    conexaoBD.Close();
                }
        }

        public static DataTable BD_dep(String codDep, String nomeDep)
        {
            using (SqlConnection conexaoBD = AcessoBD.getinstancia().getconexao())
                try
                {
                    if (codDep != "")
                    {
                        codDep = "  d.CodDependente="+codDep;

                        if (nomeDep != "")
                        {
                            nomeDep = " and d.NomeDependente like %" + nomeDep+"%";
                        }

                    }
                    else
                    {
                        if (nomeDep != "")
                        {
                            nomeDep = " d.NomeDependente like %"+nomeDep+"%";
                        }
                    }

                    conexaoBD.Open();
                    string ssql = "select * from Dependente as d inner join Responsavel as r on d.CodResponsavel=r.CodResponsavel where"+codDep+nomeDep;
                    SqlCommand cmdCommand = new SqlCommand(ssql, conexaoBD);
                    SqlDataAdapter daDataAdapter = new SqlDataAdapter(cmdCommand);
                    DataTable dtDatatable = new DataTable();
                    daDataAdapter.Fill(dtDatatable);
                    return dtDatatable;


                }
                catch (SqlException bdex)
                {
                    throw bdex;
                }
                finally
                {
                    conexaoBD.Close();
                }
        }
    }
}
