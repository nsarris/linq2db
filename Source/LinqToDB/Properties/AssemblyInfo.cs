using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

using LinqToDB;

[assembly: AssemblyTitle           (LinqToDBConstants.ProductName)]
[assembly: AssemblyDescription     (LinqToDBConstants.ProductDescription)]
[assembly: AssemblyProduct         (LinqToDBConstants.ProductName)]
[assembly: AssemblyCopyright       (LinqToDBConstants.Copyright)]
[assembly: AssemblyCulture         ("")]
[assembly: ComVisible              (false)]
[assembly: Guid                    ("080146c6-967e-4bbf-afdf-a9e0fa01d9c2")]
[assembly: CLSCompliant            (true)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: AllowPartiallyTrustedCallers]

[assembly: InternalsVisibleTo("linq2db.Tools, PublicKey=" +
	"002400000480000094000000060200000024000052534131000400000100010021259e121b7fbc" +
	"7882afdb9118a5e5ac4684296d9a48db3411402ec45fb65cb5f2b5f157856da8258874c761d2dc" +
	"0d27c09ce7fa3cd6161dabf4c81ec31ae6a793b6ded0e6cb22ec1c633cbf4081ae3842e20bfd9b" +
	"c1af84a422991ec5395f2586ebc0f5a0d1d8bde074aa2dbaca26263ebb8a0997c793ef081fe557" +
	"d7d4e3d1")]

[assembly: InternalsVisibleTo("linq2db.Tests.Base, PublicKey=" +
	"002400000480000094000000060200000024000052534131000400000100010021259e121b7fbc" +
	"7882afdb9118a5e5ac4684296d9a48db3411402ec45fb65cb5f2b5f157856da8258874c761d2dc" +
	"0d27c09ce7fa3cd6161dabf4c81ec31ae6a793b6ded0e6cb22ec1c633cbf4081ae3842e20bfd9b" +
	"c1af84a422991ec5395f2586ebc0f5a0d1d8bde074aa2dbaca26263ebb8a0997c793ef081fe557" +
	"d7d4e3d1")]

[assembly: InternalsVisibleTo("linq2db.Tests, PublicKey=" +
	"002400000480000094000000060200000024000052534131000400000100010021259e121b7fbc" +
	"7882afdb9118a5e5ac4684296d9a48db3411402ec45fb65cb5f2b5f157856da8258874c761d2dc" +
	"0d27c09ce7fa3cd6161dabf4c81ec31ae6a793b6ded0e6cb22ec1c633cbf4081ae3842e20bfd9b" +
	"c1af84a422991ec5395f2586ebc0f5a0d1d8bde074aa2dbaca26263ebb8a0997c793ef081fe557" +
	"d7d4e3d1")]

[assembly: InternalsVisibleTo("linq2db.Model, PublicKey=" +
	"002400000480000094000000060200000024000052534131000400000100010021259e121b7fbc" +
	"7882afdb9118a5e5ac4684296d9a48db3411402ec45fb65cb5f2b5f157856da8258874c761d2dc" +
	"0d27c09ce7fa3cd6161dabf4c81ec31ae6a793b6ded0e6cb22ec1c633cbf4081ae3842e20bfd9b" +
	"c1af84a422991ec5395f2586ebc0f5a0d1d8bde074aa2dbaca26263ebb8a0997c793ef081fe557" +
	"d7d4e3d1")]

[assembly: InternalsVisibleTo("linq2db.Tests.Playground, PublicKey=" +
	"002400000480000094000000060200000024000052534131000400000100010021259e121b7fbc" +
	"7882afdb9118a5e5ac4684296d9a48db3411402ec45fb65cb5f2b5f157856da8258874c761d2dc" +
	"0d27c09ce7fa3cd6161dabf4c81ec31ae6a793b6ded0e6cb22ec1c633cbf4081ae3842e20bfd9b" +
	"c1af84a422991ec5395f2586ebc0f5a0d1d8bde074aa2dbaca26263ebb8a0997c793ef081fe557" +
	"d7d4e3d1")]

[assembly: InternalsVisibleTo("linq2db4iSeries.Tests, PublicKey=" +
	"0024000004800000940000000602000000240000525341310004000001000100fdc82a08a7a5db" +
	"174ff164f03e5a94109c87bc932de05ccddf7f6fc57aeb688bb30f6915028cb96d8d5987122bea" +
	"5a1d382b594914fbbb809093f58d91344d23f5bcded36cc204c8caf24f0d62080f42d398b46002" +
	"ad9b89230f9eced7dc6cf0a915d3319e48eda4c097c0b674367df62ec2d706f58f8be59b02610e" +
	"f72e93b9")]


[assembly: InternalsVisibleTo("linq2db4iSeries.Tests.Base, PublicKey=" +
	"0024000004800000940000000602000000240000525341310004000001000100fdc82a08a7a5db" +
	"174ff164f03e5a94109c87bc932de05ccddf7f6fc57aeb688bb30f6915028cb96d8d5987122bea" +
	"5a1d382b594914fbbb809093f58d91344d23f5bcded36cc204c8caf24f0d62080f42d398b46002" +
	"ad9b89230f9eced7dc6cf0a915d3319e48eda4c097c0b674367df62ec2d706f58f8be59b02610e" +
	"f72e93b9")]


[assembly: InternalsVisibleTo("linq2db4iSeries.Model., PublicKey=" +
	"0024000004800000940000000602000000240000525341310004000001000100fdc82a08a7a5db" +
	"174ff164f03e5a94109c87bc932de05ccddf7f6fc57aeb688bb30f6915028cb96d8d5987122bea" +
	"5a1d382b594914fbbb809093f58d91344d23f5bcded36cc204c8caf24f0d62080f42d398b46002" +
	"ad9b89230f9eced7dc6cf0a915d3319e48eda4c097c0b674367df62ec2d706f58f8be59b02610e" +
	"f72e93b9")]
