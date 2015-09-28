CREATE TABLE PRODUTO (
  ID INTEGER   NOT NULL ,
  NOME VARCHAR(200)    ,
  MARCA VARCHAR(200)    ,
  QUANTIDADE INTEGER    ,
  TAMANHO INTEGER    ,
  CODIGOBARRAS VARCHAR(130)    ,
  CUSTO FLOAT    ,
  VENDA FLOAT    ,
  OBSERVACAO VARCHAR(4000)    ,
  TIPO VARCHAR(200)      ,
PRIMARY KEY(ID));




CREATE TABLE ENDERECO (
  ID INTEGER   NOT NULL ,
  LOGRADOURO VARCHAR(200)    ,
  NUMERO INTEGER    ,
  CEP VARCHAR(30)    ,
  BAIRRO VARCHAR(200)    ,
  CIDADE VARCHAR(200)    ,
  UF VARCHAR(2)      ,
PRIMARY KEY(ID));




CREATE TABLE FUNCIONARIO (
  ID INTEGER   NOT NULL ,
  ENDERECO_ID INTEGER   NOT NULL ,
  NOME VARCHAR(200)    ,
  EMAIL VARCHAR(200)    ,
  CPF VARCHAR(50)    ,
  DATANASCIMENTO INTEGER    ,
  TELEFONEPRINCIPAL VARCHAR(200)    ,
  TELEFONESECUNDARIO VARCHAR(200)    ,
  CELULAR VARCHAR(50)    ,
  LOGIN VARCHAR(20)    ,
  SENHA VARCHAR(20)    ,
  OBSERVACAO VARCHAR(4000)    ,
  STATUSATIVIDADE VARCHAR(20)      ,
PRIMARY KEY(ID)  ,
  FOREIGN KEY(ENDERECO_ID)
    REFERENCES ENDERECO(ID));


CREATE INDEX FUNCIONARIO_FKIndex1 ON FUNCIONARIO (ENDERECO_ID);


CREATE INDEX IFK_Rel_11 ON FUNCIONARIO (ENDERECO_ID);


CREATE TABLE CLIENTE (
  ID INTEGER   NOT NULL ,
  ENDERECO_ID INTEGER   NOT NULL ,
  NOME VARCHAR(200)    ,
  EMAIL VARCHAR(200)    ,
  CPF VARCHAR(50)    ,
  DATANASCIMENTO DATE    ,
  TELEFONEPRINCIPAL VARCHAR(50)    ,
  TELEFONESEGUNDARIO VARCHAR(50)    ,
  CELULAR VARCHAR(50)    ,
  OBSERVACAO VARCHAR(4000)    ,
  STATUSATIVIDADE VARCHAR(20)      ,
PRIMARY KEY(ID)  ,
  FOREIGN KEY(ENDERECO_ID)
    REFERENCES ENDERECO(ID));


CREATE INDEX CONTATO_FKIndex1 ON CLIENTE (ENDERECO_ID);


CREATE INDEX IFK_Rel_09 ON CLIENTE (ENDERECO_ID);


CREATE TABLE FORNECEDOR (
  ID INTEGER   NOT NULL ,
  ENDERECO_ID INTEGER   NOT NULL ,
  RASAO SOCIAL VARCHAR(200)    ,
  FANTASIA VARCHAR(200)    ,
  CNPJ VARCHAR(50)    ,
  EMAIL VARCHAR(200)    ,
  EMAILSECUNDARIO VARCHAR(200)    ,
  TELEFONEPRIMARIO VARCHAR(50)    ,
  TELEFONESECUNDARIO VARCHAR(50)    ,
  CELULAR VARCHAR(50)    ,
  OBSERVACOES VARCHAR(4000)      ,
PRIMARY KEY(ID)  ,
  FOREIGN KEY(ENDERECO_ID)
    REFERENCES ENDERECO(ID));


CREATE INDEX FORNECEDOR_FKIndex1 ON FORNECEDOR (ENDERECO_ID);


CREATE INDEX IFK_Rel_12 ON FORNECEDOR (ENDERECO_ID);


CREATE TABLE VENDAS (
  ID INTEGER   NOT NULL ,
  CLIENTE_ID INTEGER   NOT NULL ,
  DATAOPERACAO DATE    ,
  DESCONTO FLOAT    ,
  SUBTOTAL FLOAT    ,
  TOTAL FLOAT      ,
PRIMARY KEY(ID)  ,
  FOREIGN KEY(CLIENTE_ID)
    REFERENCES CLIENTE(ID));


CREATE INDEX VENDAS_FKIndex1 ON VENDAS (CLIENTE_ID);


CREATE INDEX IFK_Rel_10 ON VENDAS (CLIENTE_ID);


CREATE TABLE PRODUTOVENDA (
  ID INTEGER   NOT NULL ,
  VENDAS_ID INTEGER   NOT NULL ,
  PRODUTO_ID INTEGER   NOT NULL ,
  QUANTIDADE INTEGER      ,
PRIMARY KEY(ID)    ,
  FOREIGN KEY(PRODUTO_ID)
    REFERENCES PRODUTO(ID),
  FOREIGN KEY(VENDAS_ID)
    REFERENCES VENDAS(ID));


CREATE INDEX PRODUTOVENDA_FKIndex1 ON PRODUTOVENDA (PRODUTO_ID);
CREATE INDEX PRODUTOVENDA_FKIndex2 ON PRODUTOVENDA (VENDAS_ID);


CREATE INDEX IFK_Rel_07 ON PRODUTOVENDA (PRODUTO_ID);
CREATE INDEX IFK_Rel_08 ON PRODUTOVENDA (VENDAS_ID);



