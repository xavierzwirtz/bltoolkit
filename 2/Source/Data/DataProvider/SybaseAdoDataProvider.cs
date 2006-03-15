using System;
using System.Data;
using System.Data.OleDb;

namespace BLToolkit.Data.DataProvider
{
	// Data Provider for DataDirect Sybase ADO Provider 4.2
	//
	public class SybaseAdoDataProvider : OleDbDataProvider
	{
		public override bool DeriveParameters(IDbCommand command)
		{
			OleDbCommandBuilder.DeriveParameters((OleDbCommand)command);
			return true;
		}

		public override object Convert(object value, ConvertType convertType)
		{
			switch (convertType)
			{
				case ConvertType.NameToQueryParameter:
					return "?";

				case ConvertType.NameToParameter:
					return value;
			}

			return base.Convert(value, convertType);
		}

		public override void SetParameterType(IDbDataParameter parameter, object value)
		{
			if (value is string)
				parameter.DbType = DbType.AnsiString;
		}

		public override string Name
		{
			get { return "SybaseAdo"; }
		}
	}
}
