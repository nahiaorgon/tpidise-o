CREATE DATABASE PEDRO_BAR;

USE PEDRO_BAR;

CREATE TABLE productos (
 id     integer   not null,
 nombre    varchar(20)  not null,
 stock    integer   not null,
 precio    decimal(12,2) not null,
 categoria   varchar(20)  null,
 fecha_actualizacion timestamp   null
);

ALTER TABLE productos 
 ADD CONSTRAINT pk_productos 
  PRIMARY KEY (id);
 

CREATE TABLE compras (
 id     integer   not null,
 fecha    timestamp   not null,
 proveedor   varchar(50)  null
);

ALTER TABLE compras 
 ADD CONSTRAINT pk_compras 
  PRIMARY KEY (id);
 
CREATE TABLE linea_compras (
 id_compra   integer   not null,
 linea    integer   not null,
 id_producto   integer   not null,
 cantidad   integer   not null,
 precio_unitario  decimal(12,2) not null
);
 
ALTER TABLE linea_compras 
 ADD CONSTRAINT pk_linea_compras 
  PRIMARY KEY (id_compra, linea);
  
ALTER TABLE linea_compras
    ADD CONSTRAINT fk_linea_compras_ref_producto 
    FOREIGN KEY (id_producto) 
    REFERENCES productos (id);
   
ALTER TABLE linea_compras
    ADD CONSTRAINT fk_linea_compras_ref_compras 
    FOREIGN KEY (id_compra) 
    REFERENCES compras (id);
    
CREATE TABLE ventas (
 id     integer   not null,
 fecha    timestamp   not null,
 cliente    varchar(50)  null
); 

ALTER TABLE ventas 
 ADD CONSTRAINT pk_ventas 
  PRIMARY KEY (id);
 
CREATE TABLE linea_ventas (
 id_venta   integer   not null,
 linea    integer   not null,
 id_producto   integer   not null,
 cantidad   integer   not null,
 precio_unitario  decimal(12,2) not null
);
 
ALTER TABLE linea_ventas 
 ADD CONSTRAINT pk_linea_ventas 
  PRIMARY KEY (id_venta, linea);
  
ALTER TABLE linea_ventas
    ADD CONSTRAINT fk_linea_ventas_ref_productos
    FOREIGN KEY (id_producto) 
    REFERENCES productos (id);

ALTER TABLE linea_ventas
    ADD CONSTRAINT fk_linea_ventas_ref_ventas
    FOREIGN KEY (id_venta) 
    REFERENCES ventas (id);