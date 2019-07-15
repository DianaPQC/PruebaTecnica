    export interface TblCategoria {
        idCategoria: number;
        nombre: string;
        descripcion: string;
    }

    export interface TblAutor {
        idAutor: number;
        nombres: string;
        apellidos: string;
        fechaNacimiento: Date;
    }

    export interface Libro {
        idLibro: number;
        nombre: string;
        isbn: string;
        idAutor: number;
        idCategoria: number;
        tblCategoria: TblCategoria;
        tblAutor: TblAutor;
    }

