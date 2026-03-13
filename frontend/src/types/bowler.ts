// Importing teams type for the bowler type
import type { Team } from "./team"

export type bowler = {
    bowlerId: number,
    bowlerLastName: string,
    bowlerFirstName: string,
    bowlerMiddleInit: string | null,
    bowlerAddress: string,
    bowlerCity: string,
    bowlerState: string,
    bowlerZip: number,
    bowlerPhoneNumber: number,
    teamID: number,
    // from the team table, to get the team name for the bowler
    team: Team
}