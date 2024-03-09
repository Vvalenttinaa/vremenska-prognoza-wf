-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema db_vremenska_prognoza
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema db_vremenska_prognoza
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_vremenska_prognoza` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci ;
USE `db_vremenska_prognoza` ;

-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`drzava`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`drzava` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`grad`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`grad` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  `drzava_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_grad_drzava1_idx` (`drzava_id` ASC) VISIBLE,
  CONSTRAINT `fk_grad_drzava1`
    FOREIGN KEY (`drzava_id`)
    REFERENCES `db_vremenska_prognoza`.`drzava` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`adresa`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`adresa` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `ulica` VARCHAR(45) NULL,
  `broj` INT NULL,
  `grad_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_adresa_grad1_idx` (`grad_id` ASC) VISIBLE,
  CONSTRAINT `fk_adresa_grad1`
    FOREIGN KEY (`grad_id`)
    REFERENCES `db_vremenska_prognoza`.`grad` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`meteoroloska_stanica`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`meteoroloska_stanica` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `adresa_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Meteoroloska stanica_Adresa1_idx` (`adresa_id` ASC) VISIBLE,
  CONSTRAINT `fk_Meteoroloska stanica_Adresa1`
    FOREIGN KEY (`adresa_id`)
    REFERENCES `db_vremenska_prognoza`.`adresa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`nalog`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`nalog` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `lozinka` VARCHAR(45) NOT NULL,
  `korisnicko_ime` VARCHAR(45) NOT NULL,
  `uloga` CHAR(1) NOT NULL,
  `jezik` INT NULL,
  `tema` INT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`zaposleni`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`zaposleni` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `ime` VARCHAR(45) NOT NULL,
  `prezime` VARCHAR(45) NOT NULL,
  `meteoroloska_stanica_id` INT NOT NULL,
  `nalog_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Zaposleni_Meteoroloska stanica1_idx` (`meteoroloska_stanica_id` ASC) VISIBLE,
  INDEX `fk_zaposleni_nalog1_idx` (`nalog_id` ASC) VISIBLE,
  CONSTRAINT `fk_Zaposleni_Meteoroloska stanica1`
    FOREIGN KEY (`meteoroloska_stanica_id`)
    REFERENCES `db_vremenska_prognoza`.`meteoroloska_stanica` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_zaposleni_nalog1`
    FOREIGN KEY (`nalog_id`)
    REFERENCES `db_vremenska_prognoza`.`nalog` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`lokacija_instrumenata`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`lokacija_instrumenata` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `adresa_id` INT NOT NULL,
  `meteoroloska_stanica_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_lokacija_intrumenata_meteoroloska_stanica1_idx` (`meteoroloska_stanica_id` ASC) VISIBLE,
  CONSTRAINT `fk_lokacija_intrumenata_meteoroloska_stanica1`
    FOREIGN KEY (`meteoroloska_stanica_id`)
    REFERENCES `db_vremenska_prognoza`.`meteoroloska_stanica` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`mjerenje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`mjerenje` (
  `id_mjerenje` INT NOT NULL AUTO_INCREMENT,
  `vrijeme_mjerenja` DATETIME NOT NULL,
  `zaposleni_osoba_id` INT NOT NULL,
  `adresa_id` INT NOT NULL,
  `lokacija_instrumenata_id` INT NOT NULL,
  PRIMARY KEY (`id_mjerenje`),
  INDEX `fk_mjerenje_zaposleni1_idx` (`zaposleni_osoba_id` ASC) VISIBLE,
  INDEX `fk_mjerenje_adresa1_idx` (`adresa_id` ASC) VISIBLE,
  INDEX `fk_mjerenje_lokacija_instrumenta1_idx` (`lokacija_instrumenata_id` ASC) VISIBLE,
  CONSTRAINT `fk_mjerenje_zaposleni1`
    FOREIGN KEY (`zaposleni_osoba_id`)
    REFERENCES `db_vremenska_prognoza`.`zaposleni` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_mjerenje_adresa1`
    FOREIGN KEY (`adresa_id`)
    REFERENCES `db_vremenska_prognoza`.`adresa` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_mjerenje_lokacija_instrumenta1`
    FOREIGN KEY (`lokacija_instrumenata_id`)
    REFERENCES `db_vremenska_prognoza`.`lokacija_instrumenata` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`temperatura`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`temperatura` (
  `vrijednost` INT NULL,
  `mjerenje_id` INT NOT NULL,
  INDEX `fk_temperatura_mjerenje1_idx` (`mjerenje_id` ASC) VISIBLE,
  PRIMARY KEY (`mjerenje_id`),
  CONSTRAINT `fk_temperatura_mjerenje1`
    FOREIGN KEY (`mjerenje_id`)
    REFERENCES `db_vremenska_prognoza`.`mjerenje` (`id_mjerenje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`vjetar`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`vjetar` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`vjetar_mjerenje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`vjetar_mjerenje` (
  `jacina_udara` INT NULL,
  `pravac` VARCHAR(45) NULL,
  `opis` VARCHAR(45) NULL,
  `vjetar_id` INT NOT NULL,
  `mjerenje_id` INT NOT NULL,
  INDEX `fk_vjetar_mjerenje_vjetar1_idx` (`vjetar_id` ASC) VISIBLE,
  INDEX `fk_vjetar_mjerenje_mjerenje1_idx` (`mjerenje_id` ASC) VISIBLE,
  PRIMARY KEY (`mjerenje_id`),
  CONSTRAINT `fk_vjetar_mjerenje_vjetar1`
    FOREIGN KEY (`vjetar_id`)
    REFERENCES `db_vremenska_prognoza`.`vjetar` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_vjetar_mjerenje_mjerenje1`
    FOREIGN KEY (`mjerenje_id`)
    REFERENCES `db_vremenska_prognoza`.`mjerenje` (`id_mjerenje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`padavine`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`padavine` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `naziv` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `db_vremenska_prognoza`.`padavine_mjerenje`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_vremenska_prognoza`.`padavine_mjerenje` (
  `opis` VARCHAR(45) NULL,
  `vjerovatnoca` INT NULL,
  `mjerenje_id` INT NOT NULL,
  `kolicina` VARCHAR(45) NULL,
  `padavine_id` INT NOT NULL,
  PRIMARY KEY (`mjerenje_id`, `padavine_id`),
  INDEX `fk_padavine_mjerenje1_idx` (`mjerenje_id` ASC) VISIBLE,
  INDEX `fk_padavine_mjerenje_padavine1_idx` (`padavine_id` ASC) VISIBLE,
  CONSTRAINT `mjerenje_id`
    FOREIGN KEY (`mjerenje_id`)
    REFERENCES `db_vremenska_prognoza`.`mjerenje` (`id_mjerenje`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `padavine_id`
    FOREIGN KEY (`padavine_id`)
    REFERENCES `db_vremenska_prognoza`.`padavine` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
