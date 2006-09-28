using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.IO.Ports;
using Modbus.Device;
using System.Threading;

namespace Modbus.IntegrationTests
{
	[TestFixture]
	public class ModbusAsciiFixture : ModbusMasterFixture
	{
		[TestFixtureSetUp]
		public override void Init()
		{
			base.Init();

			SlaveSerialPort.Open();
			Master = ModbusSerialMaster.CreateAscii(MasterSerialPort);
			Slave = ModbusSlave.CreateAscii(SlaveAddress, SlaveSerialPort);
			Thread slaveThread = new Thread(new ThreadStart(Slave.Listen));
			slaveThread.Start();
		}

		[Test]
		public override void ReadCoils()
		{ 
			base.ReadCoils();
		}

		[Test]
		public override void Read0Coils()
		{
			base.Read0Coils();			
		}

		[Test]
		public override void ReadInputs()
		{
			base.ReadInputs();
		}

		[Test]
		public override void ReadHoldingRegisters()
		{
			base.ReadHoldingRegisters();
		}

		[Test]
		public override void ReadInputRegisters()
		{
			base.ReadInputRegisters();
		}

		[Test]
		public override void WriteSingleCoil()
		{
			base.WriteSingleCoil();
		}

		[Test]
		public override void WriteMultipleCoils()
		{
			base.WriteMultipleCoils();
		}

		[Test]
		public override void WriteSingleRegister()
		{
			base.WriteSingleRegister();
		}

		[Test]
		public override void WriteMultipleRegisters()
		{
			base.WriteMultipleRegisters();
		}
	}
}
