﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examination.Models.Enums
{
	public enum Env
	{
		invalid,
		local_sqlite,
		local_mysql,
		production,
        local_test_sqlite,
		mssql,
		test_server
	}

	
}