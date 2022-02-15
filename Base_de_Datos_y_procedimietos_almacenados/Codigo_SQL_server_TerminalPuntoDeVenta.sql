-- Se crea la base de datos
CREATE DATABASE TerminalPuntoDeVentaFarmacia;  
GO 
-- Usamos la base de datos creada para poder proceder a crear el conjunto de tablas y sus campos
USE TerminalPuntoDeVentaFarmacia;
GO

-- Creación de la tabla 'razon_social'
CREATE TABLE razon_social(
	idRS INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreRS CHAR(150) NOT NULL,
	calleRS CHAR(30) NOT NULL,
	numExtRS INT NOT NULL,
	numIntRS INT NULL,
	referenciaRS CHAR(200) NOT NULL,
	coloniaRS CHAR(40) NOT NULL,
	codigoPostalRS INT NOT NULL,
	rfcRS CHAR(13) NOT NULL,
	estadoRS CHAR(31) NOT NULL,
	municipioRS CHAR(25) NOT NULL,
	regimenFiscalRS CHAR(10) NOT NULL,
	telefonoUnoRS INT NULL,
	telefonoDosRS INT NULL,
	redSocialUnoRs CHAR(50) NULL,
	redSocialDosRS CHAR(50) NULL);
GO

-- Creación de la tabla 'existencia'
CREATE TABLE existencia(
	idExistencia INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	unidadesExistencia INT NOT NULL,
	fechaCaducidadExistencia DATE NOT NULL);
GO

-- Creación de la tabla 'laboratorio'
CREATE TABLE laboratorio(
	idLaboratorio INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreLaboratorio CHAR(50) NOT NULL);
GO

-- Creación de la tabla 'linea_articulo'
CREATE TABLE linea_articulo(
	idLineaArticulo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreLinea CHAR(50) NOT NULL);
GO

-- Creación de la tabla 'rol'
CREATE TABLE rol(
	idRol INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreRol CHAR(10) NOT NULL);
GO

-- Creación de la tabla 'medico'
CREATE TABLE medico(
	idMedico INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	cedulaProfesional INT NOT NULL,
	nombreCompletoMedico CHAR(120) NOT NULL,
	direccionConsultorioMedico CHAR(250) NOT NULL,
	especialidadMedico CHAR(30) NOT NULL,
	telefonoMedico INT NOT NULL);
GO

-- Creación de la tabla 'proveedor'
CREATE TABLE proveedor(
	idProveedor INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreProveedor CHAR(45) NOT NULL,
	fechaIngresoProveedor DATE NOT NULL,
	calleProveedor CHAR(30) NULL,
	numExtProveedor INT NULL,
	numIntProveedor INT NULL,
	coloniaProveedor CHAR(40) NULL,
	municipioProveedor CHAR(25) NULL,
	codigoPostalProveedor INT NULL,
	estadoProveedor CHAR(31) NULL,
	rfcProveedor CHAR(13) NULL,
	telefonoFijo INT NULL,
	telefonoCelular INT NULL,
	facebookProveedor CHAR(50) NULL,
	twitterProveedor CHAR(50) NULL,
	instagramProveedor CHAR(50) NULL,
	paginaWebProveedor CHAR(150) NULL,
	emailProveedor CHAR(50) NULL);
GO

-- Creación de la tabla 'sucursal'
CREATE TABLE sucursal(
	idSucursal INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	idRS INT NOT NULL,
	nombreSucursal CHAR(50) NOT NULL,
	calleSucursal CHAR(30) NOT NULL,
	numExtSucursal INT NOT NULL,
	numIntSucursal INT NULL,
	coloniaSucursal CHAR(25) NOT NULL,
	municipioSucursal CHAR(25) NOT NULL,
	codigoPostalSucursal INT NOT NULL,
	estadoSucursal CHAR(31) NOT NULL,
	CONSTRAINT fk_sucursal_razon_social
		FOREIGN KEY (idRS)
		REFERENCES razon_social (idRS)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'empleado'
CREATE TABLE empleado(
	idEmpleado INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	nombreEmpleado CHAR(60) NOT NULL,
	aPaternoEmpleado CHAR(30) NOT NULL,
	aMaternoEmpleado CHAR(30) NOT NULL,
	fechaIngresoEmpleado DATE NOT NULL,
	nombreUsuarioEmpleado CHAR(20) NOT NULL,
	contraseniaEmpleado CHAR(30) NOT NULL,
	idRol INT NOT NULL,
	numTelefonicoEmpleado INT NULL,
	calleEmpleado CHAR(30) NULL,
	numExtEmpleado INT NULL,
	numIntEmpleado INT NULL,
	coloniaEmpleado CHAR(40) NULL,
	municipioEmpleado CHAR(25) NULL,
	codigoPostalEmpleado INT NULL,
	estadoEmpleado CHAR(31) NULL,
	emailEmpleado CHAR(50) NULL,
	redSocialUnoEmpleado CHAR(50) NULL,
	redSocialDosEmpleado CHAR(50) NULL,
	idSucursal INT NOT NULL,
	CONSTRAINT fk_empleado_sucursal
		FOREIGN KEY (idSucursal)
		REFERENCES sucursal (idSucursal)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT fk_empleado_rol
		FOREIGN KEY (idRol)
		REFERENCES rol (idRol)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'receta_medica'
CREATE TABLE receta_medica(
	numeroConsecutivoRecetaMedica INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	tipoRecetaMedica CHAR(8) NOT NULL DEFAULT 'Sellada',
	idMedico INT NULL,
	CONSTRAINT fk_receta_medica_medico
		FOREIGN KEY (idMedico)
		REFERENCES medico (idMedico)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'venta'
CREATE TABLE venta(
	idVenta INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	fechaVenta DATE NOT NULL,
	horaVenta TIME NOT NULL,
	totalVenta FLOAT NOT NULL,
	tipoVenta CHAR(8) NULL,
	idEmpleado INT NOT NULL,
	idRecetaMedica INT NULL,
	CONSTRAINT fk_venta_empleado
		FOREIGN KEY (idEmpleado)
		REFERENCES empleado (idEmpleado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT fk_venta_receta_medica
		FOREIGN KEY (idRecetaMedica)
		REFERENCES receta_medica (numeroConsecutivoRecetaMedica)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'lote_articulo'
CREATE TABLE lote_articulo(
	idLoteArticulo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	claveLoteArticulo CHAR(20) NOT NULL,
	idExistencia INT NOT NULL,
	CONSTRAINT fk_lote_articulo_existencia
		FOREIGN KEY (idExistencia)
		REFERENCES existencia (idExistencia)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'articulo'
CREATE TABLE articulo(
	codigoBarrasArticulo INT NOT NULL PRIMARY KEY,
	descripcionArticulo CHAR(150) NOT NULL,
	idLineaArticulo INT NOT NULL,
	idLaboratorio INT NULL,
	idLote INT NOT NULL,
	fechaIngresoArticulo DATE NOT NULL,
	costoArticulo FLOAT NOT NULL,
	formulaArticulo CHAR(70) NULL,
	precioListadoArticulo FLOAT NULL,
	precioPublicoArticulo FLOAT NOT NULL,
	restringidoArticulo CHAR(2) NOT NULL DEFAULT 'No',
	bloqueadoArticulo CHAR(2) NOT NULL DEFAULT 'No',
	minInventarioArticulo INT NULL,
	maxInventarioArticulo INT NULL,
	reordenUnidadesArticulo INT NULL,
	exentoIvaArticulo CHAR(2) NOT NULL DEFAULT 'No',
	granelArticulo CHAR(2) NOT NULL DEFAULT 'No',
	CONSTRAINT fk_articulo_lote_articulo
		FOREIGN KEY (idLote)
		REFERENCES lote_articulo (idLoteArticulo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT fk_articulo_laboratorio
		FOREIGN KEY (idLaboratorio)
		REFERENCES laboratorio (idLaboratorio)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT fk_articulo_linea_articulo
		FOREIGN KEY (idLineaArticulo)
		REFERENCES linea_articulo (idLineaArticulo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'detalle_venta'
CREATE TABLE detalle_venta(
	codigoBarrasArticulo INT NOT NULL,
	idVenta INT NOT NULL,
	cantidadArticulo INT NOT NULL,
	subtotalVenta FLOAT NOT NULL,
	claveLoteArticulo CHAR(20) NOT NULL,
	fechaCaducidad DATE NOT NULL,
	PRIMARY KEY (codigoBarrasArticulo, idVenta),
	CONSTRAINT fk_venta_has_articulo_articulo
		FOREIGN KEY (codigoBarrasArticulo)
		REFERENCES articulo (codigoBarrasArticulo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT fk_detalle_venta_venta
		FOREIGN KEY (idVenta)
		REFERENCES venta (idVenta)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'compra'
CREATE TABLE compra(
	idCompra INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	idProveedor INT NOT NULL,
	nombreProveedorCompra CHAR(45) NOT NULL,
	sucursal CHAR(50) NOT NULL,
	numFacturaCompra CHAR(10) NOT NULL,
	ivaCompra INT NOT NULL,
	fechaRegistroCompra DATE NOT NULL,
	idEmpleado INT NOT NULL,
	creditoFecha DATE NULL,
	CONSTRAINT fk_compra_proveedor
		FOREIGN KEY (idProveedor)
		REFERENCES proveedor (idProveedor)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT fk_compra_empleado
		FOREIGN KEY (idEmpleado)
		REFERENCES empleado (idEmpleado)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO

-- Creación de la tabla 'adquisicion'
CREATE TABLE adquisicion(
	idCompra INT NOT NULL,
	codigoBarrasArticulo INT NOT NULL,
	fechaAdquisicion DATE NOT NULL,
	PRIMARY KEY (idCompra, codigoBarrasArticulo),
	CONSTRAINT fk_adquisicion_articulo1
		FOREIGN KEY (codigoBarrasArticulo)
		REFERENCES articulo (codigoBarrasArticulo)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION,
	CONSTRAINT fk_adquisicion_compra
		FOREIGN KEY (idCompra)
		REFERENCES compra (idCompra)
		ON DELETE NO ACTION
		ON UPDATE NO ACTION);
GO
