using DataAccess;
using FifaDatabase.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FifaDatabase.Helper_Code.DataDelegates
{
    internal class CreateGameDataDelegate : NonQueryDataDelegate<GameModel>
    {
        public readonly int stadiumid;
        public readonly int tournamentid;
        public readonly int teama;
        public readonly int teamb;
        public readonly DateTime date;
        public readonly string tournamentstage;
        public readonly int attendance;
        public readonly int winner;


        public CreateGameDataDelegate(int stadiumid, int tournamentid, int teama,
            int teamb, DateTime date, string tournamentstage, int attendance, int winner)
           : base("WorldCupSchema.CreateGame")
        {
            this.stadiumid = stadiumid;
            this.tournamentid = tournamentid;
            this.teama = teama;
            this.teamb = teamb;
            this.date = date;
            this.tournamentstage = tournamentstage;
            this.attendance = attendance;
            this.winner = winner;
        }

        public override void PrepareCommand(SqlCommand command)
        {
            base.PrepareCommand(command);

            var p = command.Parameters.Add("@StadiumID", SqlDbType.Int);
            p.Value = stadiumid;

            p = command.Parameters.Add("@TournamentID", SqlDbType.Int);
            p.Value = tournamentid;

            p = command.Parameters.Add("@Home", SqlDbType.Int);
            p.Value = teama;

            p = command.Parameters.Add("@Away", SqlDbType.Int);
            p.Value = teamb;

            p = command.Parameters.Add("@GameDate", SqlDbType.Date);
            p.Value = date;

            p = command.Parameters.Add("@TournamentStage", SqlDbType.NVarChar);
            p.Value = tournamentstage;

            p = command.Parameters.Add("@Attendance", SqlDbType.Int);
            p.Value = attendance;

            p = command.Parameters.Add("@Winner", SqlDbType.Int);
            p.Value = winner;

            p = command.Parameters.Add("@GameID", SqlDbType.Int);
            p.Direction = ParameterDirection.Output;
        }

        public override GameModel Translate(SqlCommand command)
        {
            GameModel gamemodel = new GameModel((int)command.Parameters["@GameID"].Value, stadiumid, tournamentid, teama, teamb, date, tournamentstage, attendance);
            return gamemodel;
        }
    }
}