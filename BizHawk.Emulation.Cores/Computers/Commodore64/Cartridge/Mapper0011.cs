﻿using System.Collections.Generic;

namespace BizHawk.Emulation.Cores.Computers.Commodore64
{
	// This mapper comes from Dinamic. It is in fact identical
	// to the System 3 mapper (000F) except that bank switching is
	// done by reads to the DExx region instead of writes.
	// This is why mapper 0011 inherits directly from 000F.

	public class Mapper0011 : Mapper000F
	{
		public Mapper0011(List<int> newAddresses, List<int> newBanks, List<byte[]> newData)
			: base(newAddresses, newBanks, newData)
		{
			// required to pass information to base class
		}

		public override void PokeDE00(int addr, byte val)
		{
			// do nothing
		}

		public override byte ReadDE00(int addr)
		{
			BankSet(addr);
			return base.ReadDE00(addr);
		}

		public override void WriteDE00(int addr, byte val)
		{
			// do nothing
		}
	}
}
