﻿using System;
using System.Collections;
using DataLayer;
using System.IO;
using System.Diagnostics;


namespace MedicalTraineeScheduling
{
	public class Program
	{
		public static int InstanceSize;
		static void Main(string[] args)
		{
            //new SolveMe().createInstanceObjCoeff(5);
            new SolveMe().solveObjCoeffGammaDelta(20, 5, 8);
            
		}

	}
}
