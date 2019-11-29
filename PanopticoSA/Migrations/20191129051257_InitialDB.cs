using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PanopticoSA.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jefe",
                columns: table => new
                {
                    IdJefe = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdEmpleado = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jefe", x => x.IdJefe);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dni = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Apellido = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IdDomicilio = table.Column<int>(nullable: false),
                    Fecha_Nacimiento = table.Column<DateTime>(nullable: true),
                    Telefono = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.IdPersona);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    IdServicio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Descripcion = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Observaciones = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.IdServicio);
                });

            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    IdArea = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    IdJefe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.IdArea);
                    table.ForeignKey(
                        name: "FK_Area_Jefe",
                        column: x => x.IdJefe,
                        principalTable: "Jefe",
                        principalColumn: "IdJefe",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdPersona = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Cliente_Persona",
                        column: x => x.IdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Domicilio",
                columns: table => new
                {
                    IdDomicilio = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calle = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    Departamento = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Piso = table.Column<int>(nullable: true),
                    Provincia = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Ciudad = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CP = table.Column<int>(nullable: false),
                    IdPersona = table.Column<int>(nullable: true),
                    Barrio = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domicilio", x => x.IdDomicilio);
                    table.ForeignKey(
                        name: "FK_Domicilio_Persona",
                        column: x => x.IdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Sueldo = table.Column<decimal>(type: "money", nullable: true),
                    IdPersona = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.IdEmpleado);
                    table.ForeignKey(
                        name: "FK_Empleado_Persona",
                        column: x => x.IdPersona,
                        principalTable: "Persona",
                        principalColumn: "IdPersona",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Presupuesto",
                columns: table => new
                {
                    IdPresupuesto = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdJefe = table.Column<int>(nullable: false),
                    IdServicio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presupuesto", x => x.IdPresupuesto);
                    table.ForeignKey(
                        name: "FK_Presupuesto_Jefe",
                        column: x => x.IdJefe,
                        principalTable: "Jefe",
                        principalColumn: "IdJefe",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Presupuesto_Servicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicio",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente_Contrata",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false),
                    IdServicio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente_Contrata", x => new { x.IdCliente, x.IdServicio });
                    table.ForeignKey(
                        name: "FK_Cliente_Contrata_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Contrata_Servicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicio",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cliente_Opina",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false),
                    IdServicio = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente_Opina", x => new { x.IdCliente, x.IdServicio });
                    table.ForeignKey(
                        name: "FK_Cliente_Opina_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Opina_Servicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicio",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    IdCuenta = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(type: "money", nullable: true),
                    Fecha_Pago = table.Column<DateTime>(nullable: true),
                    Fecha_Vencimiento = table.Column<DateTime>(nullable: true),
                    Estado = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta_1", x => new { x.IdCuenta, x.IdCliente });
                    table.ForeignKey(
                        name: "FK_Cuenta_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Emergencia",
                columns: table => new
                {
                    IdEmergencia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdCliente = table.Column<int>(nullable: false),
                    IdJefe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emergencia", x => x.IdEmergencia);
                    table.ForeignKey(
                        name: "FK_Emergencia_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    IdTurno = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true),
                    Hora = table.Column<TimeSpan>(nullable: true),
                    IdCliente = table.Column<int>(nullable: false),
                    IdServicio = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.IdTurno);
                    table.ForeignKey(
                        name: "FK_Turno_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Turno_Servicio",
                        column: x => x.IdServicio,
                        principalTable: "Servicio",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    IdTecnico = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdEmpleado = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.IdTecnico);
                    table.ForeignKey(
                        name: "FK_Tecnico_Empleado",
                        column: x => x.IdEmpleado,
                        principalTable: "Empleado",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Factura",
                columns: table => new
                {
                    IdFactura = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nro = table.Column<int>(nullable: false),
                    IdCuenta = table.Column<int>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factura", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_Factura_Cliente",
                        column: x => x.IdCliente,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Factura_Cuenta",
                        columns: x => new { x.IdCuenta, x.IdCliente },
                        principalTable: "Cuenta",
                        principalColumns: new[] { "IdCuenta", "IdCliente" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Servicio_Tecnico",
                columns: table => new
                {
                    IdTurno = table.Column<int>(nullable: false),
                    IdTecnico = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio_Tecnico", x => new { x.IdTurno, x.IdTecnico });
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Tecnico",
                        column: x => x.IdTecnico,
                        principalTable: "Tecnico",
                        principalColumn: "IdTecnico",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Servicio",
                        column: x => x.IdTurno,
                        principalTable: "Servicio",
                        principalColumn: "IdServicio",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Area_IdJefe",
                table: "Area",
                column: "IdJefe");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Contrata_IdServicio",
                table: "Cliente_Contrata",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Opina_IdServicio",
                table: "Cliente_Opina",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Cuenta_IdCliente",
                table: "Cuenta",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Domicilio_IdPersona",
                table: "Domicilio",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Emergencia_IdCliente",
                table: "Emergencia",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdPersona",
                table: "Empleado",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdCliente",
                table: "Factura",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Factura_IdCuenta_IdCliente",
                table: "Factura",
                columns: new[] { "IdCuenta", "IdCliente" });

            migrationBuilder.CreateIndex(
                name: "IX_Presupuesto_IdJefe",
                table: "Presupuesto",
                column: "IdJefe");

            migrationBuilder.CreateIndex(
                name: "IX_Presupuesto_IdServicio",
                table: "Presupuesto",
                column: "IdServicio");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_IdTecnico",
                table: "Servicio_Tecnico",
                column: "IdTecnico");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnico_IdEmpleado",
                table: "Tecnico",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdCliente",
                table: "Turno",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Turno_IdServicio",
                table: "Turno",
                column: "IdServicio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Cliente_Contrata");

            migrationBuilder.DropTable(
                name: "Cliente_Opina");

            migrationBuilder.DropTable(
                name: "Domicilio");

            migrationBuilder.DropTable(
                name: "Emergencia");

            migrationBuilder.DropTable(
                name: "Factura");

            migrationBuilder.DropTable(
                name: "Presupuesto");

            migrationBuilder.DropTable(
                name: "Servicio_Tecnico");

            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "Jefe");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
