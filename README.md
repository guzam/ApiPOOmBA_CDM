# ApiPOOmBA_CDM
-----------------------------------------------------------------------------------------------------
Api para app de preguntas y respuestas, proyecto integrador final de la materia Desarrollo Mobile.
-----------------------------------------------------------------------------------------------------
Requerimientos: 

Visual Studio con .Net Framework 4.8

SQL Server con localdb.

-----------------------------------------------------------------------------------------------------
1- Ejecutar los scripts que se encuentran en _DB_SCRIPT:

Estos scrips crean la db local con las tablas y datos para que la api funcione.

01_scrip_db_y_tablas.sql

02_scrip_insert_datos.sql

03_scrip_constraints.sql
-----------------------------------------------------------------------------------------------------

2- Abrir el proyecto ApiPOOmBA

3- Editar el archivo Web.config

buscar: 
<connectionStrings>
    <add name="DEPOOmBA01Entities"................/>
</connectionStrings>

Reemplazar los valores :

data source=<SERVER_NAME_QUE_FIGURA_EN_SQL_MANAGEMENT_STUDIO>;

password=<PASS_USUARIO_SA>;

Según correspondan en la configuración locall de tu db
-----------------------------------------------------------------------------------------------------
