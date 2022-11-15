# ApiPOOmBA_CDM
Api para app de preguntas y respuestas, proyecto integrador final de la materia Desarrollo Mobile.

1- Ejecutar los scripts que se encuentran en _DB_SCRIPT:
01_scrip_db_y_tablas.sql
02_scrip_insert_datos.sql
03_scrip_constraints.sql

El mismo crea la db local para que la api funcione.

2- Abrir el proyecto ApiPOOmBA

3- Editar el archivo Web.config

buscar: 
<connectionStrings>
    <add name="DEPOOmBA01Entities"................/>
</connectionStrings>

Reemplazar estos dos valores por los que correspondan según configuración local.
SERVER_NAME_QUE_FIGURA_EN_SQL_MANAGEMENT_STUDIO
PASS_USUARIO_SA
